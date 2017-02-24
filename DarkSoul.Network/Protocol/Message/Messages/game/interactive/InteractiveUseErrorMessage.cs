

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
    public class InteractiveUseErrorMessage : NetworkMessage
    {
        public override ushort Id => 6384;
        
        
        public uint elemId;
        public uint skillInstanceUid;
        
        public InteractiveUseErrorMessage()
        {
        }
        
        public InteractiveUseErrorMessage(uint elemId, uint skillInstanceUid)
        {
            this.elemId = elemId;
            this.skillInstanceUid = skillInstanceUid;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)elemId);
            writer.WriteVarInt((int)skillInstanceUid);
        }
        
        public override void Deserialize(IReader reader)
        {
            elemId = reader.ReadVarUhInt();
            skillInstanceUid = reader.ReadVarUhInt();
        }
        
    }
    
}