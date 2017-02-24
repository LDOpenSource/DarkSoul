

// Generated on 02/23/2017 16:53:52
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ExchangeBidPriceMessage : NetworkMessage
    {
        public override ushort Id => 5755;
        
        
        public ushort genericId;
        public double averagePrice;
        
        public ExchangeBidPriceMessage()
        {
        }
        
        public ExchangeBidPriceMessage(ushort genericId, double averagePrice)
        {
            this.genericId = genericId;
            this.averagePrice = averagePrice;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)genericId);
            writer.WriteVarLong(averagePrice);
        }
        
        public override void Deserialize(IReader reader)
        {
            genericId = reader.ReadVarUhShort();
            averagePrice = reader.ReadVarUhLong();
        }
        
    }
    
}