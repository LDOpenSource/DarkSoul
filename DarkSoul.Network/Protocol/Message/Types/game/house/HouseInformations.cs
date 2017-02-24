

// Generated on 02/23/2017 18:06:45
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class HouseInformations
    {
        public virtual short TypeId => 111;
        
        public uint houseId;
        public ushort modelId;
        
        public HouseInformations()
        {
        }
        
        public HouseInformations(uint houseId, ushort modelId)
        {
            this.houseId = houseId;
            this.modelId = modelId;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)houseId);
            writer.WriteVarShort((int)modelId);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            houseId = reader.ReadVarUhInt();
            modelId = reader.ReadVarUhShort();
        }
        
    }
    
}