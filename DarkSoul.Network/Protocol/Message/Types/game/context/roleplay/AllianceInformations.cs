

// Generated on 02/23/2017 18:06:41
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class AllianceInformations : BasicNamedAllianceInformations
    {
        public override short TypeId => 417;
        
        public Types.GuildEmblem allianceEmblem;
        
        public AllianceInformations()
        {
        }
        
        public AllianceInformations(uint allianceId, string allianceTag, string allianceName, Types.GuildEmblem allianceEmblem)
         : base(allianceId, allianceTag, allianceName)
        {
            this.allianceEmblem = allianceEmblem;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            allianceEmblem.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            allianceEmblem = new Types.GuildEmblem();
            allianceEmblem.Deserialize(reader);
        }
        
    }
    
}