

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
    public class ExchangeTypesItemsExchangerDescriptionForUserMessage : NetworkMessage
    {
        public override ushort Id => 5752;
        
        
        public IEnumerable<Types.BidExchangerObjectInfo> itemTypeDescriptions;
        
        public ExchangeTypesItemsExchangerDescriptionForUserMessage()
        {
        }
        
        public ExchangeTypesItemsExchangerDescriptionForUserMessage(IEnumerable<Types.BidExchangerObjectInfo> itemTypeDescriptions)
        {
            this.itemTypeDescriptions = itemTypeDescriptions;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)itemTypeDescriptions.Count());
            foreach (var entry in itemTypeDescriptions)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            itemTypeDescriptions = new Types.BidExchangerObjectInfo[limit];
            for (int i = 0; i < limit; i++)
            {
                 (itemTypeDescriptions as Types.BidExchangerObjectInfo[])[i] = new Types.BidExchangerObjectInfo();
                 (itemTypeDescriptions as Types.BidExchangerObjectInfo[])[i].Deserialize(reader);
            }
        }
        
    }
    
}