

// Generated on 02/23/2017 18:06:38
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class EntityMovementInformations
    {
        public virtual short TypeId => 63;
        
        public int id;
        public IEnumerable<sbyte> steps;
        
        public EntityMovementInformations()
        {
        }
        
        public EntityMovementInformations(int id, IEnumerable<sbyte> steps)
        {
            this.id = id;
            this.steps = steps;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteInt(id);
            writer.WriteShort((short)steps.Count());
            foreach (var entry in steps)
            {
                 writer.WriteSByte(entry);
            }
        }
        
        public virtual void Deserialize(IReader reader)
        {
            id = reader.ReadInt();
            var limit = reader.ReadUShort();
            steps = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 (steps as sbyte[])[i] = reader.ReadSByte();
            }
        }
        
    }
    
}