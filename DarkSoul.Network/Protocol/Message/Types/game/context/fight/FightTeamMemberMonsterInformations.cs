

// Generated on 02/23/2017 18:06:39
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class FightTeamMemberMonsterInformations : FightTeamMemberInformations
    {
        public override short TypeId => 6;
        
        public int monsterId;
        public sbyte grade;
        
        public FightTeamMemberMonsterInformations()
        {
        }
        
        public FightTeamMemberMonsterInformations(double id, int monsterId, sbyte grade)
         : base(id)
        {
            this.monsterId = monsterId;
            this.grade = grade;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteInt(monsterId);
            writer.WriteSByte(grade);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            monsterId = reader.ReadInt();
            grade = reader.ReadSByte();
        }
        
    }
    
}