using DarkSoul.Network.Interface;
using System;
using System.Net;
using System.Net.Sockets;
using System.Reactive;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Text;
using System.Threading;
using Newtonsoft.Json;
using DarkSoul.Network.Extension;
using System.Reflection;
using System.Linq;
using System.Collections.Concurrent;
using DarkSoul.Core.Reflection;
using DarkSoul.Network.IPC.Server.Descriptors;
using System.Collections.Generic;
using DarkSoul.Network.IPC.Server.Lookup;
using DarkSoul.Network.IPC.Server.Json;
using System.Diagnostics;

namespace DarkSoul.Network.IPC.Server
{
    public class SoulServer : IConnection
    {
        public static readonly ConcurrentDictionary<string, DynamicMethodDelegate> _handlers
            = new ConcurrentDictionary<string, DynamicMethodDelegate>();

        public static readonly ConcurrentDictionary<string, IList<ParameterDescriptor>> _params
            = new ConcurrentDictionary<string, IList<ParameterDescriptor>>();

        public CancellationTokenSource Cancel { get; private set; }

        public JsonSerializer JsonSerializer { get; internal set; } = new JsonSerializer();

        public SoulServer(string ip, int port)
        {
            Cancel = new CancellationTokenSource();
            Build();
            Init(ip, port);
        }

        private void Build()
        {
            var souls =
                from type in typeof(ISoul).GetTypeInfo().Assembly.GetTypes()
                where type.GetTypeInfo().ImplementedInterfaces.Contains((typeof(ISoul)))
                select type;

            foreach (var message in souls)
            {
                var methods = message.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
                foreach (var method in methods)
                {
                    _handlers.TryAdd(method.Name, DynamicDelegateStaticFactory.CreateMethodCaller(method));
                    var param = ExtractProgressParameter(method.GetParameters(), out var type);
                    _params.TryAdd(method.Name, param.Select(x => new ParameterDescriptor {
                        Name = x.Name,
                        ParameterType = x.ParameterType
                    }).ToList());
                }
            }
        }

        private void Init(string ip, int port)
        {
            new IPEndPoint(IPAddress.Parse(ip), port).ToListenerObservable(10)
                .ObserveOn(TaskPoolScheduler.Default)
                .Subscribe(
                    client =>
                        client.ToClientObservable(1024)
                            .Finally(() => {
                                client.Dispose();
                                Console.WriteLine("Client Disconnected"); //TODO ClientManager Add/Remove
                            })
                            .Subscribe(ToClientObserver(client, Cancel.Token), Cancel.Token),
                    error => Console.WriteLine("Error: " + error.Message),
                    () => Console.WriteLine("Socket Disconnected"),
                    Cancel.Token);
            Console.WriteLine("Server Init");
        }

        private static IEnumerable<ParameterInfo> ExtractProgressParameter(ParameterInfo[] parameters, out Type progressReportingType)
        {
            var lastParameter = parameters.LastOrDefault();
            progressReportingType = null;

            if (IsProgressType(lastParameter))
            {
                // This method takes an IProgress<T> as the last parameter and thus supports progress reporting
                progressReportingType = lastParameter.ParameterType.GenericTypeArguments[0];

                // Strip the IProgress<T> param from the method descriptor params list
                // as we don't want to include it when trying to match methods
                return parameters.Take(parameters.Length - 1);
            }

            return parameters;
        }

        private static bool IsProgressType(ParameterInfo parameter)
        {
            return parameter != null
                && parameter.ParameterType.GetTypeInfo().IsGenericType
                && parameter.ParameterType.GetGenericTypeDefinition() == typeof(IProgress<>);
        }

        private IObserver<ArraySegment<byte>> ToClientObserver(Socket socket, CancellationToken token)
        {
            return ToStreamObserver(new NetworkStream(socket), token);
        }

        private IObserver<ArraySegment<byte>> ToStreamObserver(NetworkStream stream, CancellationToken token)
        {
            return Observer.Create<ArraySegment<byte>>(async buffer =>
            {
                var response = Encoding.UTF8.GetString(buffer.Array, 0, buffer.Count);
                var result = this.JsonDeserializeObject<ServerSoulInvocation>(response);
                
                ServerMsgResult msg;
                if (_handlers.TryGetValue(result.Method, out var value))
                {
                    IJsonValue[] parameterValues = result.Args.Select(x => new JRawValue(x)).ToArray();
                    var args = DefaultParameterResolver.ResolveMethodParameters(_params[result.Method], parameterValues).ToArray();
                    var messageToSend = value.Invoke(value.Target, args);
                    msg = new ServerMsgResult
                    {
                        Id = result.CallbackId,
                        Result = messageToSend
                    };
                }
                else
                {
                    msg = new ServerMsgResult
                    {
                        Id = result.CallbackId,
                        Result = null,
                        Error = "Handlers don't contain the method"
                    };
                }
                var writeBuffer = Encoding.UTF8.GetBytes(this.JsonSerializeObject(msg));
                await stream.WriteAsync(writeBuffer, 0, writeBuffer.Length, token);
            });
        }
    }
}
