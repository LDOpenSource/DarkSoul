

// Generated on 02/23/2017 18:06:40
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class FightTeamMemberWithAllianceCharacterInformations : FightTeamMemberCharacterInformations
    {
        public override short TypeId => 426;
        
        public Types.BasicAllianceInformations allianceInfos;
        
        public FightTeamMemberWithAllianceCharacterInformations()
        {
        }
        
        public FightTeamMemberWithAllianceCharacterInformations(double id, string name, byte level, Types.BasicAllianceInformations allianceInfos)
         : base(id, name, level)
        {
            this.allianceInfos = allianceInfos;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            allianceInfos.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            allianceInfos = new Types.BasicAllianceInformations();
            allianceInfos.Deserialize(reader);
        }
        
    }
    
}