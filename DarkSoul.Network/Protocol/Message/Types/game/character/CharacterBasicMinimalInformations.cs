

// Generated on 02/23/2017 18:06:37
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class CharacterBasicMinimalInformations : AbstractCharacterInformation
    {
        public override short TypeId => 503;
        
        public string name;
        
        public CharacterBasicMinimalInformations()
        {
        }
        
        public CharacterBasicMinimalInformations(double id, string name)
         : base(id)
        {
            this.name = name;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(name);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            name = reader.ReadUTF();
        }
        
    }
    
}