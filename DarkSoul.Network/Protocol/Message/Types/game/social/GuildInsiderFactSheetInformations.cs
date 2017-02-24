

// Generated on 02/23/2017 18:06:47
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class GuildInsiderFactSheetInformations : GuildFactSheetInformations
    {
        public override short TypeId => 423;
        
        public string leaderName;
        public ushort nbConnectedMembers;
        public sbyte nbTaxCollectors;
        public int lastActivity;
        
        public GuildInsiderFactSheetInformations()
        {
        }
        
        public GuildInsiderFactSheetInformations(uint guildId, string guildName, byte guildLevel, Types.GuildEmblem guildEmblem, double leaderId, ushort nbMembers, string leaderName, ushort nbConnectedMembers, sbyte nbTaxCollectors, int lastActivity)
         : base(guildId, guildName, guildLevel, guildEmblem, leaderId, nbMembers)
        {
            this.leaderName = leaderName;
            this.nbConnectedMembers = nbConnectedMembers;
            this.nbTaxCollectors = nbTaxCollectors;
            this.lastActivity = lastActivity;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(leaderName);
            writer.WriteVarShort((int)nbConnectedMembers);
            writer.WriteSByte(nbTaxCollectors);
            writer.WriteInt(lastActivity);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            leaderName = reader.ReadUTF();
            nbConnectedMembers = reader.ReadVarUhShort();
            nbTaxCollectors = reader.ReadSByte();
            lastActivity = reader.ReadInt();
        }
        
    }
    
}