using DarkSoul.Network.Attribute;
using DarkSoul.Network.Protocol;
using DarkSoul.Network.Protocol.Messages;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DarkSoul.GUI.Auth.Protocol
{
    public static class AuthHandler
    {
        [Handle(182)]
        public static IEnumerable<NetworkMessage> HandleBasicPingMessage(Stream client, BasicPingMessage message)
        {
            yield return new BasicPongMessage(message.quiet);
        }

        [Handle(4)]
        public static IEnumerable<NetworkMessage> HandleIdentificationMessage(Stream client, IdentificationMessage message)
        {
            // Add to queue etc...
            return Enumerable.Empty<NetworkMessage>();
        }
    }
}
