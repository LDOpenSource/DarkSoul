using System;
using System.Net.Sockets;

namespace DarkSoul.Network
{
    public static class ClientExtensions
    {
        public static IObservable<ArraySegment<byte>> ToClientObservable(this Socket socket, int size)
        {
            return new NetworkStream(socket).ToStreamObservable(size);
        }
    }
}
