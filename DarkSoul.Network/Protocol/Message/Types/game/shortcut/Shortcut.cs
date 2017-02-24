

// Generated on 02/23/2017 18:06:46
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class Shortcut
    {
        public virtual short TypeId => 369;
        
        public sbyte slot;
        
        public Shortcut()
        {
        }
        
        public Shortcut(sbyte slot)
        {
            this.slot = slot;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteSByte(slot);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            slot = reader.ReadSByte();
        }
        
    }
    
}