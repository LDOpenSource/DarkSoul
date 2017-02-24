

// Generated on 02/23/2017 18:06:47
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class GuildInAllianceVersatileInformations : GuildVersatileInformations
    {
        public override short TypeId => 437;
        
        public uint allianceId;
        
        public GuildInAllianceVersatileInformations()
        {
        }
        
        public GuildInAllianceVersatileInformations(uint guildId, double leaderId, byte guildLevel, byte nbMembers, uint allianceId)
         : base(guildId, leaderId, guildLevel, nbMembers)
        {
            this.allianceId = allianceId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt((int)allianceId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            allianceId = reader.ReadVarUhInt();
        }
        
    }
    
}