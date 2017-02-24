

// Generated on 02/23/2017 18:06:46
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class UpdateMountBoost
    {
        public virtual short TypeId => 356;
        
        public sbyte type;
        
        public UpdateMountBoost()
        {
        }
        
        public UpdateMountBoost(sbyte type)
        {
            this.type = type;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteSByte(type);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            type = reader.ReadSByte();
        }
        
    }
    
}