

// Generated on 02/23/2017 18:06:46
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class IndexedEntityLook
    {
        public virtual short TypeId => 405;
        
        public Types.EntityLook look;
        public sbyte index;
        
        public IndexedEntityLook()
        {
        }
        
        public IndexedEntityLook(Types.EntityLook look, sbyte index)
        {
            this.look = look;
            this.index = index;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            look.Serialize(writer);
            writer.WriteSByte(index);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            look = new Types.EntityLook();
            look.Deserialize(reader);
            index = reader.ReadSByte();
        }
        
    }
    
}