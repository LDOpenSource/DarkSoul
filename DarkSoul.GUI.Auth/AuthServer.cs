using System;
using System.Net.Sockets;
using System.Threading;
using DarkSoul.Network;

namespace DarkSoul.GUI.Auth
{
    public class AuthServer : BaseServer
    {
        public AuthServer(string ip, int port) : base(ip, port)
        {
        }
        
        /// <summary>
        /// This initiate the Main Thread for the AuthServer
        /// </summary>
        public override void Init()
        {
            //do your init stuff
        }

        public override IObserver<ArraySegment<byte>> ToClientObserver(Socket socket, CancellationToken token)
        {
            return new AuthClient(socket, token).ToStreamObserver(token); //just use this like a AuthServer
        }
    }
}
