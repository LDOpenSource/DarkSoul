

// Generated on 02/23/2017 16:53:50
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class InteractiveUseEndedMessage : NetworkMessage
    {
        public override ushort Id => 6112;
        
        
        public uint elemId;
        public ushort skillId;
        
        public InteractiveUseEndedMessage()
        {
        }
        
        public InteractiveUseEndedMessage(uint elemId, ushort skillId)
        {
            this.elemId = elemId;
            this.skillId = skillId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)elemId);
            writer.WriteVarShort((int)skillId);
        }
        
        public override void Deserialize(IReader reader)
        {
            elemId = reader.ReadVarUhInt();
            skillId = reader.ReadVarUhShort();
        }
        
    }
    
}