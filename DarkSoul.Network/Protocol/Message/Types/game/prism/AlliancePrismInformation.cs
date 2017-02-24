

// Generated on 02/23/2017 18:06:46
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class AlliancePrismInformation : PrismInformation
    {
        public override short TypeId => 427;
        
        public Types.AllianceInformations alliance;
        
        public AlliancePrismInformation()
        {
        }
        
        public AlliancePrismInformation(sbyte typeId, sbyte state, int nextVulnerabilityDate, int placementDate, uint rewardTokenCount, Types.AllianceInformations alliance)
         : base(typeId, state, nextVulnerabilityDate, placementDate, rewardTokenCount)
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
            alliance = new Types.AllianceInformations();
            alliance.Deserialize(reader);
        }
        
    }
    
}