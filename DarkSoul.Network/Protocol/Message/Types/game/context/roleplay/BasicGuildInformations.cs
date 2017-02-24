

// Generated on 02/23/2017 18:06:41
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class BasicGuildInformations : AbstractSocialGroupInfos
    {
        public override short TypeId => 365;
        
        public uint guildId;
        public string guildName;
        public byte guildLevel;
        
        public BasicGuildInformations()
        {
        }
        
        public BasicGuildInformations(uint guildId, string guildName, byte guildLevel)
        {
            this.guildId = guildId;
            this.guildName = guildName;
            this.guildLevel = guildLevel;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt((int)guildId);
            writer.WriteUTF(guildName);
            writer.WriteByte(guildLevel);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            guildId = reader.ReadVarUhInt();
            guildName = reader.ReadUTF();
            guildLevel = reader.ReadByte();
        }
        
    }
    
}