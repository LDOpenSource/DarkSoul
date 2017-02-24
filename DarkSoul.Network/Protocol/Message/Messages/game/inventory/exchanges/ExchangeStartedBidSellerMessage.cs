

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
    public class ExchangeStartedBidSellerMessage : NetworkMessage
    {
        public override ushort Id => 5905;
        
        
        public Types.SellerBuyerDescriptor sellerDescriptor;
        public IEnumerable<Types.ObjectItemToSellInBid> objectsInfos;
        
        public ExchangeStartedBidSellerMessage()
        {
        }
        
        public ExchangeStartedBidSellerMessage(Types.SellerBuyerDescriptor sellerDescriptor, IEnumerable<Types.ObjectItemToSellInBid> objectsInfos)
        {
            this.sellerDescriptor = sellerDescriptor;
            this.objectsInfos = objectsInfos;
        }
        
        public override void Serialize(IWriter writer)
        {
            sellerDescriptor.Serialize(writer);
            writer.WriteShort((short)objectsInfos.Count());
            foreach (var entry in objectsInfos)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            sellerDescriptor = new Types.SellerBuyerDescriptor();
            sellerDescriptor.Deserialize(reader);
            var limit = reader.ReadUShort();
            objectsInfos = new Types.ObjectItemToSellInBid[limit];
            for (int i = 0; i < limit; i++)
            {
                 (objectsInfos as Types.ObjectItemToSellInBid[])[i] = new Types.ObjectItemToSellInBid();
                 (objectsInfos as Types.ObjectItemToSellInBid[])[i].Deserialize(reader);
            }
        }
        
    }
    
}