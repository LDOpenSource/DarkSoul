

// Generated on 02/23/2017 18:06:47
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class AlliancedGuildFactSheetInformations : GuildInformations
    {
        public override short TypeId => 422;
        
        public Types.BasicNamedAllianceInformations allianceInfos;
        
        public AlliancedGuildFactSheetInformations()
        {
        }
        
        public AlliancedGuildFactSheetInformations(uint guildId, string guildName, byte guildLevel, Types.GuildEmblem guildEmblem, Types.BasicNamedAllianceInformations allianceInfos)
         : base(guildId, guildName, guildLevel, guildEmblem)
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
            allianceInfos = new Types.BasicNamedAllianceInformations();
            allianceInfos.Deserialize(reader);
        }
        
    }
    
}