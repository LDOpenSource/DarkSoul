

// Generated on 02/23/2017 18:06:45
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class TaxCollectorLootInformations : TaxCollectorComplementaryInformations
    {
        public override short TypeId => 372;
        
        public double kamas;
        public double experience;
        public uint pods;
        public double itemsValue;
        
        public TaxCollectorLootInformations()
        {
        }
        
        public TaxCollectorLootInformations(double kamas, double experience, uint pods, double itemsValue)
        {
            this.kamas = kamas;
            this.experience = experience;
            this.pods = pods;
            this.itemsValue = itemsValue;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(kamas);
            writer.WriteVarLong(experience);
            writer.WriteVarInt((int)pods);
            writer.WriteVarLong(itemsValue);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            kamas = reader.ReadVarUhLong();
            experience = reader.ReadVarUhLong();
            pods = reader.ReadVarUhInt();
            itemsValue = reader.ReadVarUhLong();
        }
        
    }
    
}