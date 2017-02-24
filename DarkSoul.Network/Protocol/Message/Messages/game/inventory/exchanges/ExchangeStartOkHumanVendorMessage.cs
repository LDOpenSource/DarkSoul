

// Generated on 02/23/2017 16:53:56
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ExchangeStartOkHumanVendorMessage : NetworkMessage
    {
        public override ushort Id => 5767;
        
        
        public double sellerId;
        public IEnumerable<Types.ObjectItemToSellInHumanVendorShop> objectsInfos;
        
        public ExchangeStartOkHumanVendorMessage()
        {
        }
        
        public ExchangeStartOkHumanVendorMessage(double sellerId, IEnumerable<Types.ObjectItemToSellInHumanVendorShop> objectsInfos)
        {
            this.sellerId = sellerId;
            this.objectsInfos = objectsInfos;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteDouble(sellerId);
            writer.WriteShort((short)objectsInfos.Count());
            foreach (var entry in objectsInfos)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            sellerId = reader.ReadDouble();
            var limit = reader.ReadUShort();
            objectsInfos = new Types.ObjectItemToSellInHumanVendorShop[limit];
            for (int i = 0; i < limit; i++)
            {
                 (objectsInfos as Types.ObjectItemToSellInHumanVendorShop[])[i] = new Types.ObjectItemToSellInHumanVendorShop();
                 (objectsInfos as Types.ObjectItemToSellInHumanVendorShop[])[i].Deserialize(reader);
            }
        }
        
    }
    
}