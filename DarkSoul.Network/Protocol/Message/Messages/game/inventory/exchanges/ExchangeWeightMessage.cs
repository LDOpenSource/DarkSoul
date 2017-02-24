

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
    public class ExchangeWeightMessage : NetworkMessage
    {
        public override ushort Id => 5793;
        
        
        public uint currentWeight;
        public uint maxWeight;
        
        public ExchangeWeightMessage()
        {
        }
        
        public ExchangeWeightMessage(uint currentWeight, uint maxWeight)
        {
            this.currentWeight = currentWeight;
            this.maxWeight = maxWeight;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)currentWeight);
            writer.WriteVarInt((int)maxWeight);
        }
        
        public override void Deserialize(IReader reader)
        {
            currentWeight = reader.ReadVarUhInt();
            maxWeight = reader.ReadVarUhInt();
        }
        
    }
    
}