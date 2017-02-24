

// Generated on 02/23/2017 16:53:26
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class PlayerStatusUpdateRequestMessage : NetworkMessage
    {
        public override ushort Id => 6387;
        
        
        public Types.PlayerStatus status;
        
        public PlayerStatusUpdateRequestMessage()
        {
        }
        
        public PlayerStatusUpdateRequestMessage(Types.PlayerStatus status)
        {
            this.status = status;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort(status.TypeId);
            status.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            status = ProtocolTypeManager.GetInstance<Types.PlayerStatus>(reader.ReadUShort());
            status.Deserialize(reader);
        }
        
    }
    
}