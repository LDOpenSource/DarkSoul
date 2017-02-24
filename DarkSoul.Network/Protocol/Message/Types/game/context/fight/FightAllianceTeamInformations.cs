

// Generated on 02/23/2017 18:06:39
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class FightAllianceTeamInformations : FightTeamInformations
    {
        public override short TypeId => 439;
        
        public sbyte relation;
        
        public FightAllianceTeamInformations()
        {
        }
        
        public FightAllianceTeamInformations(sbyte teamId, double leaderId, sbyte teamSide, sbyte teamTypeId, sbyte nbWaves, IEnumerable<Types.FightTeamMemberInformations> teamMembers, sbyte relation)
         : base(teamId, leaderId, teamSide, teamTypeId, nbWaves, teamMembers)
        {
            this.relation = relation;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSByte(relation);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            relation = reader.ReadSByte();
        }
        
    }
    
}