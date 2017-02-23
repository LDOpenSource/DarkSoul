using DarkSoul.Network.Protocol;
using DarkSoul.Network.Protocol.Message;
using System;
using System.Net;
using System.Net.Sockets;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Reflection;
using System.Threading;

namespace DarkSoul.Network
{
    public abstract class BaseServer
    {
        public BaseServer(string ip, int port)
        {
            Ip = ip;
            Port = port;
        }

        /// <summary>
        /// Network port to bind
        /// </summary>
        public int Port { get; private set; }

        /// <summary>
        /// Network Ip to bind
        /// </summary>
        public string Ip { get; private set; }


        public void Initialize(Assembly assembly)
        {
            MessageHandler.Instance.Initilize(assembly);
            MessageReceiver.Instance.Build();
            Init();

            // Init socket
            var cts = new CancellationTokenSource();

            //TODO Bind custom client to manage disconnect and all those kind
            new IPEndPoint(IPAddress.Parse(Ip), Port).ToListenerObservable(10)
                .ObserveOn(TaskPoolScheduler.Default)
                .Subscribe(
                    client =>
                        client.ToClientObservable(1024)
                            .Subscribe(client.ToClientObserver(cts.Token), cts.Token),
                    error => Console.WriteLine("Error: " + error.Message),
                    () => Console.WriteLine("Client Disconnected"),
                    cts.Token);
        }

        public abstract void Init();

        public abstract IObserver<ArraySegment<byte>> ToClientObserver(Socket socket, CancellationToken token);
    }
}
