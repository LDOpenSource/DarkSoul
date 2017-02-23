using System;
using System.Net;
using System.Net.Sockets;
using System.Reactive.Linq;

namespace DarkSoul.Network
{
    public static class ListenerExtensions
    {
        public static IObservable<Socket> ToListenerObservable(this IPEndPoint endpoint, int backlog)
        {
            var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(endpoint);
            return socket.ToListenerObservable(backlog);
        }

        public static IObservable<Socket> ToListenerObservable(this Socket socket, int backlog)
        {
            return Observable.Create<Socket>(async (observer, token) =>
            {
                socket.Listen(backlog);

                try
                {
                    while (!token.IsCancellationRequested)
                        observer.OnNext(await socket.AcceptAsync());

                    observer.OnCompleted();

                    socket.Dispose(); // TODO: Correct way to do it?
                }
                catch (Exception error)
                {
                    observer.OnError(error);
                }
            });
        }
    }
}
