

// Generated on 02/23/2017 18:06:39
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class FightTeamMemberCharacterInformations : FightTeamMemberInformations
    {
        public override short TypeId => 13;
        
        public string name;
        public byte level;
        
        public FightTeamMemberCharacterInformations()
        {
        }
        
        public FightTeamMemberCharacterInformations(double id, string name, byte level)
         : base(id)
        {
            this.name = name;
            this.level = level;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(name);
            writer.WriteByte(level);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            name = reader.ReadUTF();
            level = reader.ReadByte();
        }
        
    }
    
}