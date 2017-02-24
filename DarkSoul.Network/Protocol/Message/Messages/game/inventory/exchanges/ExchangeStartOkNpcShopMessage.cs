

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
    public class ExchangeStartOkNpcShopMessage : NetworkMessage
    {
        public override ushort Id => 5761;
        
        
        public double npcSellerId;
        public ushort tokenId;
        public IEnumerable<Types.ObjectItemToSellInNpcShop> objectsInfos;
        
        public ExchangeStartOkNpcShopMessage()
        {
        }
        
        public ExchangeStartOkNpcShopMessage(double npcSellerId, ushort tokenId, IEnumerable<Types.ObjectItemToSellInNpcShop> objectsInfos)
        {
            this.npcSellerId = npcSellerId;
            this.tokenId = tokenId;
            this.objectsInfos = objectsInfos;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteDouble(npcSellerId);
            writer.WriteVarShort((int)tokenId);
            writer.WriteShort((short)objectsInfos.Count());
            foreach (var entry in objectsInfos)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            npcSellerId = reader.ReadDouble();
            tokenId = reader.ReadVarUhShort();
            var limit = reader.ReadUShort();
            objectsInfos = new Types.ObjectItemToSellInNpcShop[limit];
            for (int i = 0; i < limit; i++)
            {
                 (objectsInfos as Types.ObjectItemToSellInNpcShop[])[i] = new Types.ObjectItemToSellInNpcShop();
                 (objectsInfos as Types.ObjectItemToSellInNpcShop[])[i].Deserialize(reader);
            }
        }
        
    }
    
}