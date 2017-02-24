

// Generated on 02/23/2017 18:06:46
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class SubEntity
    {
        public virtual short TypeId => 54;
        
        public sbyte bindingPointCategory;
        public sbyte bindingPointIndex;
        public Types.EntityLook subEntityLook;
        
        public SubEntity()
        {
        }
        
        public SubEntity(sbyte bindingPointCategory, sbyte bindingPointIndex, Types.EntityLook subEntityLook)
        {
            this.bindingPointCategory = bindingPointCategory;
            this.bindingPointIndex = bindingPointIndex;
            this.subEntityLook = subEntityLook;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteSByte(bindingPointCategory);
            writer.WriteSByte(bindingPointIndex);
            subEntityLook.Serialize(writer);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            bindingPointCategory = reader.ReadSByte();
            bindingPointIndex = reader.ReadSByte();
            subEntityLook = new Types.EntityLook();
            subEntityLook.Deserialize(reader);
        }
        
    }
    
}