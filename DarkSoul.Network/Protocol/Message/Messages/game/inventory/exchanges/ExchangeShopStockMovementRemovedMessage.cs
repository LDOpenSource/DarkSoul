

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
    public class ExchangeShopStockMovementRemovedMessage : NetworkMessage
    {
        public override ushort Id => 5907;
        
        
        public uint objectId;
        
        public ExchangeShopStockMovementRemovedMessage()
        {
        }
        
        public ExchangeShopStockMovementRemovedMessage(uint objectId)
        {
            this.objectId = objectId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)objectId);
        }
        
        public override void Deserialize(IReader reader)
        {
            objectId = reader.ReadVarUhInt();
        }
        
    }
    
}