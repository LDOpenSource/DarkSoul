

// Generated on 02/23/2017 16:53:54
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ExchangeOfflineSoldItemsMessage : NetworkMessage
    {
        public override ushort Id => 6613;
        
        
        public IEnumerable<Types.ObjectItemGenericQuantityPrice> bidHouseItems;
        public IEnumerable<Types.ObjectItemGenericQuantityPrice> merchantItems;
        
        public ExchangeOfflineSoldItemsMessage()
        {
        }
        
        public ExchangeOfflineSoldItemsMessage(IEnumerable<Types.ObjectItemGenericQuantityPrice> bidHouseItems, IEnumerable<Types.ObjectItemGenericQuantityPrice> merchantItems)
        {
            this.bidHouseItems = bidHouseItems;
            this.merchantItems = merchantItems;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)bidHouseItems.Count());
            foreach (var entry in bidHouseItems)
            {
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)merchantItems.Count());
            foreach (var entry in merchantItems)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            bidHouseItems = new Types.ObjectItemGenericQuantityPrice[limit];
            for (int i = 0; i < limit; i++)
            {
                 (bidHouseItems as Types.ObjectItemGenericQuantityPrice[])[i] = new Types.ObjectItemGenericQuantityPrice();
                 (bidHouseItems as Types.ObjectItemGenericQuantityPrice[])[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            merchantItems = new Types.ObjectItemGenericQuantityPrice[limit];
            for (int i = 0; i < limit; i++)
            {
                 (merchantItems as Types.ObjectItemGenericQuantityPrice[])[i] = new Types.ObjectItemGenericQuantityPrice();
                 (merchantItems as Types.ObjectItemGenericQuantityPrice[])[i].Deserialize(reader);
            }
        }
        
    }
    
}