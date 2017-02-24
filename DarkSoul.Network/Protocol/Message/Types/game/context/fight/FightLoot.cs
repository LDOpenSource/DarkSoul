

// Generated on 02/23/2017 18:06:39
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class FightLoot
    {
        public virtual short TypeId => 41;
        
        public IEnumerable<ushort> objects;
        public double kamas;
        
        public FightLoot()
        {
        }
        
        public FightLoot(IEnumerable<ushort> objects, double kamas)
        {
            this.objects = objects;
            this.kamas = kamas;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteShort((short)objects.Count());
            foreach (var entry in objects)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteVarLong(kamas);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            objects = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (objects as ushort[])[i] = reader.ReadVarUhShort();
            }
            kamas = reader.ReadVarUhLong();
        }
        
    }
    
}