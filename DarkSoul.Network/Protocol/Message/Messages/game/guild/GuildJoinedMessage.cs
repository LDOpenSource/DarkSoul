

// Generated on 02/23/2017 16:53:48
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GuildJoinedMessage : NetworkMessage
    {
        public override ushort Id => 5564;
        
        
        public Types.GuildInformations guildInfo;
        public uint memberRights;
        
        public GuildJoinedMessage()
        {
        }
        
        public GuildJoinedMessage(Types.GuildInformations guildInfo, uint memberRights)
        {
            this.guildInfo = guildInfo;
            this.memberRights = memberRights;
        }
        
        public override void Serialize(IWriter writer)
        {
            guildInfo.Serialize(writer);
            writer.WriteVarInt((int)memberRights);
        }
        
        public override void Deserialize(IReader reader)
        {
            guildInfo = new Types.GuildInformations();
            guildInfo.Deserialize(reader);
            memberRights = reader.ReadVarUhInt();
        }
        
    }
    
}