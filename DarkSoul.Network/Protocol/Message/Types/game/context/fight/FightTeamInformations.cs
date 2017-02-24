

// Generated on 02/23/2017 18:06:39
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class FightTeamInformations : AbstractFightTeamInformations
    {
        public override short TypeId => 33;
        
        public IEnumerable<Types.FightTeamMemberInformations> teamMembers;
        
        public FightTeamInformations()
        {
        }
        
        public FightTeamInformations(sbyte teamId, double leaderId, sbyte teamSide, sbyte teamTypeId, sbyte nbWaves, IEnumerable<Types.FightTeamMemberInformations> teamMembers)
         : base(teamId, leaderId, teamSide, teamTypeId, nbWaves)
        {
            this.teamMembers = teamMembers;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort((short)teamMembers.Count());
            foreach (var entry in teamMembers)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            var limit = reader.ReadUShort();
            teamMembers = new Types.FightTeamMemberInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (teamMembers as Types.FightTeamMemberInformations[])[i] = ProtocolTypeManager.GetInstance<Types.FightTeamMemberInformations>(reader.ReadUShort());
                 (teamMembers as Types.FightTeamMemberInformations[])[i].Deserialize(reader);
            }
        }
        
    }
    
}