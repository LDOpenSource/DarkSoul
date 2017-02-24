

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
    public class ServerSelectionMessage : NetworkMessage
    {
        public override ushort Id => 40;
        
        
        public ushort serverId;
        
        public ServerSelectionMessage()
        {
        }
        
        public ServerSelectionMessage(ushort serverId)
        {
            this.serverId = serverId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)serverId);
        }
        
        public override void Deserialize(IReader reader)
        {
            serverId = reader.ReadVarUhShort();
        }
        
    }
    
}