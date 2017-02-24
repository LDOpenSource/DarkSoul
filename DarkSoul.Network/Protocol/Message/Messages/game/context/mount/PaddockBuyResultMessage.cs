

// Generated on 02/23/2017 16:53:33
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class PaddockBuyResultMessage : NetworkMessage
    {
        public override ushort Id => 6516;
        
        
        public int paddockId;
        public bool bought;
        public double realPrice;
        
        public PaddockBuyResultMessage()
        {
        }
        
        public PaddockBuyResultMessage(int paddockId, bool bought, double realPrice)
        {
            this.paddockId = paddockId;
            this.bought = bought;
            this.realPrice = realPrice;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteInt(paddockId);
            writer.WriteBoolean(bought);
            writer.WriteVarLong(realPrice);
        }
        
        public override void Deserialize(IReader reader)
        {
            paddockId = reader.ReadInt();
            bought = reader.ReadBoolean();
            realPrice = reader.ReadVarUhLong();
        }
        
    }
    
}