

// Generated on 02/23/2017 18:06:38
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class EntityDispositionInformations
    {
        public virtual short TypeId => 60;
        
        public short cellId;
        public sbyte direction;
        
        public EntityDispositionInformations()
        {
        }
        
        public EntityDispositionInformations(short cellId, sbyte direction)
        {
            this.cellId = cellId;
            this.direction = direction;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteShort(cellId);
            writer.WriteSByte(direction);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            cellId = reader.ReadShort();
            direction = reader.ReadSByte();
        }
        
    }
    
}