

// Generated on 02/23/2017 16:53:16
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ServerStatusUpdateMessage : NetworkMessage
    {
        public override ushort Id => 50;
        
        
        public Types.GameServerInformations server;
        
        public ServerStatusUpdateMessage()
        {
        }
        
        public ServerStatusUpdateMessage(Types.GameServerInformations server)
        {
            this.server = server;
        }
        
        public override void Serialize(IWriter writer)
        {
            server.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            server = new Types.GameServerInformations();
            server.Deserialize(reader);
        }
        
    }
    
}