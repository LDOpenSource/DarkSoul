using System.Net.Sockets;

namespace DarkSoul.GUI.Auth
{
    public class AuthClient : NetworkStream
    {
        public AuthClient(Socket socket) : base(socket)
        {
        }

        public AuthClient(Socket socket, bool ownsSocket) : base(socket, ownsSocket)
        {
        }

        public void SendMessage()
        {

        }
    }
}
