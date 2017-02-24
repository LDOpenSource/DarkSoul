

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
    public class ExchangeBidHouseUnsoldItemsMessage : NetworkMessage
    {
        public override ushort Id => 6612;
        
        
        public IEnumerable<Types.ObjectItemGenericQuantity> items;
        
        public ExchangeBidHouseUnsoldItemsMessage()
        {
        }
        
        public ExchangeBidHouseUnsoldItemsMessage(IEnumerable<Types.ObjectItemGenericQuantity> items)
        {
            this.items = items;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)items.Count());
            foreach (var entry in items)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            items = new Types.ObjectItemGenericQuantity[limit];
            for (int i = 0; i < limit; i++)
            {
                 (items as Types.ObjectItemGenericQuantity[])[i] = new Types.ObjectItemGenericQuantity();
                 (items as Types.ObjectItemGenericQuantity[])[i].Deserialize(reader);
            }
        }
        
    }
    
}