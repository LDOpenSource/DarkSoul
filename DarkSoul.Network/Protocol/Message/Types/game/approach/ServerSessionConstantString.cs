

// Generated on 02/23/2017 18:06:37
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class ServerSessionConstantString : ServerSessionConstant
    {
        public override short TypeId => 436;
        
        public string value;
        
        public ServerSessionConstantString()
        {
        }
        
        public ServerSessionConstantString(ushort id, string value)
         : base(id)
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