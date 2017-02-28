using System;
using Newtonsoft.Json;
using System.Text;
using System.Globalization;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net;
using System.Threading;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Net.Sockets;
using DarkSoul.Network.Extension;
using Newtonsoft.Json.Linq;
using DarkSoul.Network.Interface;
using System.Reactive;
using System.Diagnostics;

namespace DarkSoul.Network.IPC
{
    /// <summary>
    /// A implementation based on signalr HubConnection from Microsoft
    /// </summary>
    public class SoulConnection : IConnection
    {
        #region Fields

        internal readonly Dictionary<string, Action<MsgResult>> _callbacks = new Dictionary<string, Action<MsgResult>>();
        private int _callbackId;
        private NetworkStream ClientStream;

        #endregion

        public SoulConnection(string ip, int port)
        {
            Cancel = new CancellationTokenSource();
            Init(ip, port);
        }

        #region Props

        public JsonSerializer JsonSerializer { get; internal set; } = new JsonSerializer();

        public CancellationTokenSource Cancel { get; private set; }

        #endregion

        #region Methods

        /// <summary>
        /// Return a SoulProxy to make method calls
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public SoulProxy CreateSoulProxy(string name = "soulproxy") //add functionality later for name
        {
            return new SoulProxy(this, name);
        }

        public string RegisterCallback(Action<MsgResult> callback)
        {
            lock (_callbacks)
            {
                string id = _callbackId.ToString(CultureInfo.InvariantCulture);
                _callbacks[id] = callback;
                _callbackId++;
                return id;
            }
        }

        internal void RemoveCallback(string callbackId)
        {
            lock (_callbacks)
            {
                _callbacks.Remove(callbackId);
            }
        }

        private void Init(string ip, int port)
        {
            new IPEndPoint(IPAddress.Parse(ip), port).ToConnectObservable()
                .ObserveOn(TaskPoolScheduler.Default)
                .Subscribe(
                    client =>
                        client.ToClientObservable(1024)
                            .Finally(() => {
                                client.Dispose();
                                Console.WriteLine("Server Disconnected"); 
                            })
                            .Subscribe(ToClientObserver(client, Cancel.Token, out ClientStream), Cancel.Token),
                    error => Console.WriteLine("Error: " + error.Message),
                    () => Console.WriteLine("Client Socket Disconnected"),
                    Cancel.Token);
            Console.WriteLine("Client Init");
        }

        public Task Send(string value)
        {
            if (ClientStream == null)
            {
                throw new ArgumentNullException("ClientSteam");
            }

            if (!ClientStream.CanWrite)
            {
                var ex = new InvalidOperationException("Client Stream can write");
                var tcs = new TaskCompletionSource<object>();
                tcs.SetException(ex);
                return tcs.Task;
            }
            //send over socket
            var writeBuffer = Encoding.UTF8.GetBytes(value);

            return Task.WhenAll(new Task[]
                    {
                        ClientStream.WriteAsync(writeBuffer, 0, writeBuffer.Length, Cancel.Token),
                        ClientStream.FlushAsync(Cancel.Token)
                    });
        }

        private void OnReceived(MsgResult result)
        {
            Action<MsgResult> callback;

            lock (_callbacks)
            {
                if (_callbacks.TryGetValue(result.Id, out callback))
                    _callbacks.Remove(result.Id);
                else
                    Console.WriteLine("Callback with id " + result.Id + " not found!");
            }

            callback?.Invoke(result);
        }

        private IObserver<ArraySegment<byte>> ToClientObserver(Socket socket, CancellationToken token, out NetworkStream stream)
        {
            return ToStreamObserver(stream = new NetworkStream(socket), token);
        }

        private IObserver<ArraySegment<byte>> ToStreamObserver(NetworkStream stream, CancellationToken token)
        {
            return Observer.Create<ArraySegment<byte>>(buffer =>
            {
                var response = Encoding.UTF8.GetString(buffer.Array, 0, buffer.Array.Length);

                try
                {
                    var result = this.JsonDeserializeObject<MsgResult>(response);

                    OnReceived(result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"A error ocurred when deserialize MsgResult - Message: {ex.Message} - Trace: {ex.StackTrace}");
                } 
            });
        }

        #endregion
    }
}