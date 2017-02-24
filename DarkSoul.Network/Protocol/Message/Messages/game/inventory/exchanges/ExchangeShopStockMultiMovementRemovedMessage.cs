

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
    public class ExchangeShopStockMultiMovementRemovedMessage : NetworkMessage
    {
        public override ushort Id => 6037;
        
        
        public IEnumerable<uint> objectIdList;
        
        public ExchangeShopStockMultiMovementRemovedMessage()
        {
        }
        
        public ExchangeShopStockMultiMovementRemovedMessage(IEnumerable<uint> objectIdList)
        {
            this.objectIdList = objectIdList;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)objectIdList.Count());
            foreach (var entry in objectIdList)
            {
                 writer.WriteVarInt((int)entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            objectIdList = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 (objectIdList as uint[])[i] = reader.ReadVarUhInt();
            }
        }
        
    }
    
}