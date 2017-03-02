using System;
using System.Net.Sockets;
using System.Threading;
using DarkSoul.Network;
using DarkSoul.Network.IPC.Server;
using DarkSoul.Core.Attribute;

namespace DarkSoul.GUI.Auth
{
    public class AuthServer : BaseServer
    {
        [Variable] public static string auth_ip = "127.0.0.1";
        [Variable] public static int auth_port = 5555;
        [Variable] public static string srv_ipc_ip = "127.0.0.1";
        [Variable] public static int srv_ipc_port = 5556;

        public AuthServer() : base(auth_ip, auth_port) { }
        
        /// <summary>
        /// This initiate the Main Thread for the AuthServer
        /// </summary>
        public override void Init()
        {
            var ipcSrv = new SoulServer(srv_ipc_ip, srv_ipc_port);

            Console.WriteLine($"SoulServer Init on port: {srv_ipc_port}");
        }

        /// <summary>
        /// Convert socket to stream observable
        /// </summary>
        /// <param name="socket">Actual connected socket to convert to stream</param>
        /// <param name="token">Cancelation token</param>
        /// <param name="client">Out the abstract client builded</param>
        /// <returns></returns>
        public override IObserver<ArraySegment<byte>> ToClientObserver(Socket socket, CancellationToken token, out BaseClient client)
        {
            client = new AuthClient(socket, token);
            var observer = client.ToStreamObserver(token);
            client.Observer = observer;
            client.Socket = socket;
            return observer; //just use this like a AuthServer
        }
    }
}
