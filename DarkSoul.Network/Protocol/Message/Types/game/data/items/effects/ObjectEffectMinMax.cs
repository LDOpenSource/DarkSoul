

// Generated on 02/23/2017 18:06:44
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class ObjectEffectMinMax : ObjectEffect
    {
        public override short TypeId => 82;
        
        public uint min;
        public uint max;
        
        public ObjectEffectMinMax()
        {
        }
        
        public ObjectEffectMinMax(ushort actionId, uint min, uint max)
         : base(actionId)
        {
            this.min = min;
            this.max = max;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt((int)min);
            writer.WriteVarInt((int)max);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            min = reader.ReadVarUhInt();
            max = reader.ReadVarUhInt();
        }
        
    }
    
}