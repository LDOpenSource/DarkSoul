using System;
using System.Net.Sockets;
using System.Threading;

namespace DarkSoul.Network
{
    public static class ClientExtensions
    {
        public static IObservable<ArraySegment<byte>> ToClientObservable(this Socket socket, int size)
        {
            return new NetworkStream(socket).ToStreamObservable(size);
        }

        public static IObserver<ArraySegment<byte>> ToClientObserver(this Socket socket, CancellationToken token)
        {
            return new NetworkStream(socket).ToStreamObserver(token);
        }
    }
}
