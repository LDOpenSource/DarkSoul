

// Generated on 02/23/2017 18:06:42
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class GuildInAllianceInformations : GuildInformations
    {
        public override short TypeId => 420;
        
        public byte nbMembers;
        
        public GuildInAllianceInformations()
        {
        }
        
        public GuildInAllianceInformations(uint guildId, string guildName, byte guildLevel, Types.GuildEmblem guildEmblem, byte nbMembers)
         : base(guildId, guildName, guildLevel, guildEmblem)
        {
            this.nbMembers = nbMembers;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteByte(nbMembers);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            nbMembers = reader.ReadByte();
        }
        
    }
    
}