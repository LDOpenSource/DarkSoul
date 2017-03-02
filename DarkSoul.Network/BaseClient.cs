using DarkSoul.Network.Protocol;
using System;
using System.Net.Sockets;
using System.Threading;

namespace DarkSoul.Network
{
    /// <summary>
    /// Abstract Stream Client class
    /// </summary>
    public abstract class BaseClient : NetworkStream
    {
        /// <summary>
        /// Cancelation Token
        /// </summary>
        public CancellationToken Cancelation { get; set; }

        /// <summary>
        /// Stream Observable
        /// </summary>
        public IObserver<ArraySegment<byte>> Observer { get; set; }

        /// <summary>
        /// Client Socket
        /// </summary>
        public Socket Socket { get; set; }

        public BaseClient(Socket socket, CancellationToken token) : base(socket)
        {
            Cancelation = token;
        }

        public BaseClient(Socket socket, bool ownsSocket, CancellationToken token) : base(socket, ownsSocket)
        {
            Cancelation = token;
        }

        /// <summary>
        /// Send message to the server
        /// </summary>
        /// <param name="message"></param>
        public abstract void SendMessage(NetworkMessage message);

        /// <summary>
        /// Disconect forcelly the client
        /// </summary>
        public void Disconnect()
        {
            Observer.OnCompleted();
            Socket.Dispose();
            Dispose();
        }
    }
}
