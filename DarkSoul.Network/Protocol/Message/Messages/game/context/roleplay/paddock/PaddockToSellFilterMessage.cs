

// Generated on 02/23/2017 16:53:39
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class PaddockToSellFilterMessage : NetworkMessage
    {
        public override ushort Id => 6161;
        
        
        public int areaId;
        public sbyte atLeastNbMount;
        public sbyte atLeastNbMachine;
        public double maxPrice;
        
        public PaddockToSellFilterMessage()
        {
        }
        
        public PaddockToSellFilterMessage(int areaId, sbyte atLeastNbMount, sbyte atLeastNbMachine, double maxPrice)
        {
            this.areaId = areaId;
            this.atLeastNbMount = atLeastNbMount;
            this.atLeastNbMachine = atLeastNbMachine;
            this.maxPrice = maxPrice;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteInt(areaId);
            writer.WriteSByte(atLeastNbMount);
            writer.WriteSByte(atLeastNbMachine);
            writer.WriteVarLong(maxPrice);
        }
        
        public override void Deserialize(IReader reader)
        {
            areaId = reader.ReadInt();
            atLeastNbMount = reader.ReadSByte();
            atLeastNbMachine = reader.ReadSByte();
            maxPrice = reader.ReadVarUhLong();
        }
        
    }
    
}