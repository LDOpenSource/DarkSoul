

// Generated on 02/23/2017 18:06:46
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class ItemDurability
    {
        public virtual short TypeId => 168;
        
        public short durability;
        public short durabilityMax;
        
        public ItemDurability()
        {
        }
        
        public ItemDurability(short durability, short durabilityMax)
        {
            this.durability = durability;
            this.durabilityMax = durabilityMax;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteShort(durability);
            writer.WriteShort(durabilityMax);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            durability = reader.ReadShort();
            durabilityMax = reader.ReadShort();
        }
        
    }
    
}