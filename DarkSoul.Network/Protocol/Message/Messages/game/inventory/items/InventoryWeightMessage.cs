

// Generated on 02/23/2017 16:53:58
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class InventoryWeightMessage : NetworkMessage
    {
        public override ushort Id => 3009;
        
        
        public uint weight;
        public uint weightMax;
        
        public InventoryWeightMessage()
        {
        }
        
        public InventoryWeightMessage(uint weight, uint weightMax)
        {
            this.weight = weight;
            this.weightMax = weightMax;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)weight);
            writer.WriteVarInt((int)weightMax);
        }
        
        public override void Deserialize(IReader reader)
        {
            weight = reader.ReadVarUhInt();
            weightMax = reader.ReadVarUhInt();
        }
        
    }
    
}