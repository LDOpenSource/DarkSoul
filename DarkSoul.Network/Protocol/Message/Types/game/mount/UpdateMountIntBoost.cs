

// Generated on 02/23/2017 18:06:46
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class UpdateMountIntBoost : UpdateMountBoost
    {
        public override short TypeId => 357;
        
        public int value;
        
        public UpdateMountIntBoost()
        {
        }
        
        public UpdateMountIntBoost(sbyte type, int value)
         : base(type)
        {
            this.value = value;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteInt(value);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            value = reader.ReadInt();
        }
        
    }
    
}