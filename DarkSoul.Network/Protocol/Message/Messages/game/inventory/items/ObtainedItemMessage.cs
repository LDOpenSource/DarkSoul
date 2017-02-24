

// Generated on 02/23/2017 16:53:59
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ObtainedItemMessage : NetworkMessage
    {
        public override ushort Id => 6519;
        
        
        public ushort genericId;
        public uint baseQuantity;
        
        public ObtainedItemMessage()
        {
        }
        
        public ObtainedItemMessage(ushort genericId, uint baseQuantity)
        {
            this.genericId = genericId;
            this.baseQuantity = baseQuantity;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)genericId);
            writer.WriteVarInt((int)baseQuantity);
        }
        
        public override void Deserialize(IReader reader)
        {
            genericId = reader.ReadVarUhShort();
            baseQuantity = reader.ReadVarUhInt();
        }
        
    }
    
}