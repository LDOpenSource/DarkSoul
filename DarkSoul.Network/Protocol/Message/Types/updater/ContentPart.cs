

// Generated on 02/23/2017 18:06:47
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class ContentPart
    {
        public virtual short TypeId => 350;
        
        public string id;
        public sbyte state;
        
        public ContentPart()
        {
        }
        
        public ContentPart(string id, sbyte state)
        {
            this.id = id;
            this.state = state;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteUTF(id);
            writer.WriteSByte(state);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            id = reader.ReadUTF();
            state = reader.ReadSByte();
        }
        
    }
    
}