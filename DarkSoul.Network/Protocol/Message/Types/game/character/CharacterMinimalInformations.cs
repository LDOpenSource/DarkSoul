

// Generated on 02/23/2017 18:06:38
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class CharacterMinimalInformations : CharacterBasicMinimalInformations
    {
        public override short TypeId => 110;
        
        public byte level;
        
        public CharacterMinimalInformations()
        {
        }
        
        public CharacterMinimalInformations(double id, string name, byte level)
         : base(id, name)
        {
            this.level = level;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteByte(level);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            level = reader.ReadByte();
        }
        
    }
    
}