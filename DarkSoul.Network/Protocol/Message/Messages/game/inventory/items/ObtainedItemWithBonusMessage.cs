

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
    public class ObtainedItemWithBonusMessage : ObtainedItemMessage
    {
        public override ushort Id => 6520;
        
        
        public uint bonusQuantity;
        
        public ObtainedItemWithBonusMessage()
        {
        }
        
        public ObtainedItemWithBonusMessage(ushort genericId, uint baseQuantity, uint bonusQuantity)
         : base(genericId, baseQuantity)
        {
            this.bonusQuantity = bonusQuantity;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt((int)bonusQuantity);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            bonusQuantity = reader.ReadVarUhInt();
        }
        
    }
    
}