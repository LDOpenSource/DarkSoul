

// Generated on 02/23/2017 18:06:38
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class CharacterMinimalGuildInformations : CharacterMinimalPlusLookInformations
    {
        public override short TypeId => 445;
        
        public Types.BasicGuildInformations guild;
        
        public CharacterMinimalGuildInformations()
        {
        }
        
        public CharacterMinimalGuildInformations(double id, string name, byte level, Types.EntityLook entityLook, Types.BasicGuildInformations guild)
         : base(id, name, level, entityLook)
        {
            this.guild = guild;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            guild.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            guild = new Types.BasicGuildInformations();
            guild.Deserialize(reader);
        }
        
    }
    
}