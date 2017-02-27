using System;
using System.Net.Sockets;
using System.Reactive.Subjects;
using System.ServiceModel.Channels;
using System.Threading;

namespace DarkSoul.Network.Extension
{
    public static class FrameClientExtensions
    {
        public static ISubject<DisposableValue<ArraySegment<byte>>, DisposableValue<ArraySegment<byte>>> ToFrameClientSubject(this Socket socket, BufferManager bufferManager, CancellationToken token, out NetworkStream stream)
        {
            stream = new NetworkStream(socket);
            return Subject.Create<DisposableValue<ArraySegment<byte>>, DisposableValue<ArraySegment<byte>>>(stream.ToFrameStreamObserver(token), stream.ToFrameStreamObservable(bufferManager));
        }
    }
}
