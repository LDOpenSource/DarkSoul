

// Generated on 02/23/2017 18:06:44
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class ObjectEffectString : ObjectEffect
    {
        public override short TypeId => 74;
        
        public string value;
        
        public ObjectEffectString()
        {
        }
        
        public ObjectEffectString(ushort actionId, string value)
         : base(actionId)
        {
            this.value = value;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(value);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            value = reader.ReadUTF();
        }
        
    }
    
}