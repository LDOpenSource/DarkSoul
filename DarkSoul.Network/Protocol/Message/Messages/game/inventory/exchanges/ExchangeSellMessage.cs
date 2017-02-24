

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
    public class ExchangeSellMessage : NetworkMessage
    {
        public override ushort Id => 5778;
        
        
        public uint objectToSellId;
        public uint quantity;
        
        public ExchangeSellMessage()
        {
        }
        
        public ExchangeSellMessage(uint objectToSellId, uint quantity)
        {
            this.objectToSellId = objectToSellId;
            this.quantity = quantity;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)objectToSellId);
            writer.WriteVarInt((int)quantity);
        }
        
        public override void Deserialize(IReader reader)
        {
            objectToSellId = reader.ReadVarUhInt();
            quantity = reader.ReadVarUhInt();
        }
        
    }
    
}