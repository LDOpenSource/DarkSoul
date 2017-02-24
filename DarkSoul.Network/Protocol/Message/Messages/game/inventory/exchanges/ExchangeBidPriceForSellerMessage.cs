

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
    public class ExchangeBidPriceForSellerMessage : ExchangeBidPriceMessage
    {
        public override ushort Id => 6464;
        
        
        public bool allIdentical;
        public IEnumerable<double> minimalPrices;
        
        public ExchangeBidPriceForSellerMessage()
        {
        }
        
        public ExchangeBidPriceForSellerMessage(ushort genericId, double averagePrice, bool allIdentical, IEnumerable<double> minimalPrices)
         : base(genericId, averagePrice)
        {
            this.allIdentical = allIdentical;
            this.minimalPrices = minimalPrices;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteBoolean(allIdentical);
            writer.WriteShort((short)minimalPrices.Count());
            foreach (var entry in minimalPrices)
            {
                 writer.WriteVarLong(entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            allIdentical = reader.ReadBoolean();
            var limit = reader.ReadUShort();
            minimalPrices = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 (minimalPrices as double[])[i] = reader.ReadVarUhLong();
            }
        }
        
    }
    
}