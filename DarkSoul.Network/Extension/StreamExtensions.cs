﻿using DarkSoul.Core.IO;
using DarkSoul.Network.Protocol;
using DarkSoul.Network.Protocol.Message;
using System;
using System.IO;
using System.Reactive;
using System.Reactive.Linq;
using System.Threading;

namespace DarkSoul.Network
{
    public static class StreamExtensions
    {
        public static IObservable<ArraySegment<byte>> ToStreamObservable(this Stream stream, int size)
        {
            return Observable.Create<ArraySegment<byte>>(async (observer, token) =>
            {
                var buffer = new byte[size];

                try
                {
                    while (!token.IsCancellationRequested)
                    {
                        var received = await stream.ReadAsync(buffer, 0, size, token);
                        if (received == 0)
                            break;

                        observer.OnNext(new ArraySegment<byte>(buffer, 0, received));
                    }

                    observer.OnCompleted();
                }
                catch (Exception error)
                {
                    observer.OnError(error);
                }
            });
        }

        public static IObserver<ArraySegment<byte>> ToStreamObserver(this Stream stream, CancellationToken token)
        {
            return Observer.Create<ArraySegment<byte>>(async buffer =>
            {
                var mb = new MessageBuilder();
                var reader = new BigEndianReader(buffer.Array, buffer.Count);
                while (mb.Build(reader))
                {
                    reader = new BigEndianReader(mb.Data, mb.Data.Length);
                    Console.WriteLine($"Recieved messageId: {mb.MessageId}, Data length: {mb.Data.Length}");
                    var message = MessageReceiver.Instance.BuildMessage((ushort)mb.MessageId, reader);
                    var messagesToSend = MessageHandler.Instance.Process(message, stream);
                    foreach (var msg in messagesToSend)
                    {
                        using (var writer = new BigEndianWriter())
                        {
                            msg.Pack(writer);
                            await stream.WriteAsync(writer.Data, 0, writer.Data.Length, token);
                        }                        
                    }
                }
                
            });
        }
    }
}