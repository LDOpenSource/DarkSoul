

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
    public class ExchangeShopStockStartedMessage : NetworkMessage
    {
        public override ushort Id => 5910;
        
        
        public IEnumerable<Types.ObjectItemToSell> objectsInfos;
        
        public ExchangeShopStockStartedMessage()
        {
        }
        
        public ExchangeShopStockStartedMessage(IEnumerable<Types.ObjectItemToSell> objectsInfos)
        {
            this.objectsInfos = objectsInfos;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)objectsInfos.Count());
            foreach (var entry in objectsInfos)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            objectsInfos = new Types.ObjectItemToSell[limit];
            for (int i = 0; i < limit; i++)
            {
                 (objectsInfos as Types.ObjectItemToSell[])[i] = new Types.ObjectItemToSell();
                 (objectsInfos as Types.ObjectItemToSell[])[i].Deserialize(reader);
            }
        }
        
    }
    
}