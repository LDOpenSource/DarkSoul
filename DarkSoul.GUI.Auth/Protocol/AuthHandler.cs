using DarkSoul.Network.Attribute;
using DarkSoul.Network.Protocol;
using DarkSoul.Network.Protocol.Message;
using System.Collections.Generic;
using System.IO;

namespace DarkSoul.GUI.Auth.Protocol
{
    public static class AuthHandler
    {
        [Handle(182)]
        public static IEnumerable<NetworkMessage> HandleBasicPingMessage(Stream client, BasicPingMessage message)
        {
            yield return new BasicPongMessage(message.quiet);
        }
    }
}
