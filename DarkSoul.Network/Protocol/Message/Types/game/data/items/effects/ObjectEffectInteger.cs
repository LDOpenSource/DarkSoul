

// Generated on 02/23/2017 18:06:44
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class ObjectEffectInteger : ObjectEffect
    {
        public override short TypeId => 70;
        
        public ushort value;
        
        public ObjectEffectInteger()
        {
        }
        
        public ObjectEffectInteger(ushort actionId, ushort value)
         : base(actionId)
        {
            this.value = value;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((int)value);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            value = reader.ReadVarUhShort();
        }
        
    }
    
}