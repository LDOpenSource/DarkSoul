using System;
using System.Net.Sockets;
using System.Threading;
using DarkSoul.Network;
using DarkSoul.Network.IPC.Server;

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
            var ipcSrv = new SoulServer("127.0.0.1", 5556);

            Console.WriteLine("SoulServer Init on port 5556 :D");
        }

        public override IObserver<ArraySegment<byte>> ToClientObserver(Socket socket, CancellationToken token)
        {
            return new AuthClient(socket, token).ToStreamObserver(token); //just use this like a AuthServer
        }
    }
}
