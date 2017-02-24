

// Generated on 02/23/2017 16:53:55
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ExchangeShopStockMultiMovementUpdatedMessage : NetworkMessage
    {
        public override ushort Id => 6038;
        
        
        public IEnumerable<Types.ObjectItemToSell> objectInfoList;
        
        public ExchangeShopStockMultiMovementUpdatedMessage()
        {
        }
        
        public ExchangeShopStockMultiMovementUpdatedMessage(IEnumerable<Types.ObjectItemToSell> objectInfoList)
        {
            this.objectInfoList = objectInfoList;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)objectInfoList.Count());
            foreach (var entry in objectInfoList)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            objectInfoList = new Types.ObjectItemToSell[limit];
            for (int i = 0; i < limit; i++)
            {
                 (objectInfoList as Types.ObjectItemToSell[])[i] = new Types.ObjectItemToSell();
                 (objectInfoList as Types.ObjectItemToSell[])[i].Deserialize(reader);
            }
        }
        
    }
    
}