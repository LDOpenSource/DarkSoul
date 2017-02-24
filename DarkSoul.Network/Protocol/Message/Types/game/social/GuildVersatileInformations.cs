

// Generated on 02/23/2017 18:06:47
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class GuildVersatileInformations
    {
        public virtual short TypeId => 435;
        
        public uint guildId;
        public double leaderId;
        public byte guildLevel;
        public byte nbMembers;
        
        public GuildVersatileInformations()
        {
        }
        
        public GuildVersatileInformations(uint guildId, double leaderId, byte guildLevel, byte nbMembers)
        {
            this.guildId = guildId;
            this.leaderId = leaderId;
            this.guildLevel = guildLevel;
            this.nbMembers = nbMembers;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)guildId);
            writer.WriteVarLong(leaderId);
            writer.WriteByte(guildLevel);
            writer.WriteByte(nbMembers);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            guildId = reader.ReadVarUhInt();
            leaderId = reader.ReadVarUhLong();
            guildLevel = reader.ReadByte();
            nbMembers = reader.ReadByte();
        }
        
    }
    
}