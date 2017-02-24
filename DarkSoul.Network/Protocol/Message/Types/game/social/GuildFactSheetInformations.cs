

// Generated on 02/23/2017 18:06:47
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class GuildFactSheetInformations : GuildInformations
    {
        public override short TypeId => 424;
        
        public double leaderId;
        public ushort nbMembers;
        
        public GuildFactSheetInformations()
        {
        }
        
        public GuildFactSheetInformations(uint guildId, string guildName, byte guildLevel, Types.GuildEmblem guildEmblem, double leaderId, ushort nbMembers)
         : base(guildId, guildName, guildLevel, guildEmblem)
        {
            this.leaderId = leaderId;
            this.nbMembers = nbMembers;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(leaderId);
            writer.WriteVarShort((int)nbMembers);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            leaderId = reader.ReadVarUhLong();
            nbMembers = reader.ReadVarUhShort();
        }
        
    }
    
}