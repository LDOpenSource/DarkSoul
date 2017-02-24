

// Generated on 02/23/2017 18:06:42
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class GuildInformations : BasicGuildInformations
    {
        public override short TypeId => 127;
        
        public Types.GuildEmblem guildEmblem;
        
        public GuildInformations()
        {
        }
        
        public GuildInformations(uint guildId, string guildName, byte guildLevel, Types.GuildEmblem guildEmblem)
         : base(guildId, guildName, guildLevel)
        {
            this.guildEmblem = guildEmblem;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            guildEmblem.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            guildEmblem = new Types.GuildEmblem();
            guildEmblem.Deserialize(reader);
        }
        
    }
    
}