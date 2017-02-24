

// Generated on 02/23/2017 18:06:38
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class CharacterMinimalAllianceInformations : CharacterMinimalGuildInformations
    {
        public override short TypeId => 444;
        
        public Types.BasicAllianceInformations alliance;
        
        public CharacterMinimalAllianceInformations()
        {
        }
        
        public CharacterMinimalAllianceInformations(double id, string name, byte level, Types.EntityLook entityLook, Types.BasicGuildInformations guild, Types.BasicAllianceInformations alliance)
         : base(id, name, level, entityLook, guild)
        {
            this.alliance = alliance;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            alliance.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            alliance = new Types.BasicAllianceInformations();
            alliance.Deserialize(reader);
        }
        
    }
    
}