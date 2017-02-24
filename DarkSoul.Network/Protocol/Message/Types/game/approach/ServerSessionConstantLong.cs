

// Generated on 02/23/2017 18:06:37
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class ServerSessionConstantLong : ServerSessionConstant
    {
        public override short TypeId => 429;
        
        public double value;
        
        public ServerSessionConstantLong()
        {
        }
        
        public ServerSessionConstantLong(ushort id, double value)
         : base(id)
        {
            this.value = value;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(value);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            value = reader.ReadDouble();
        }
        
    }
    
}