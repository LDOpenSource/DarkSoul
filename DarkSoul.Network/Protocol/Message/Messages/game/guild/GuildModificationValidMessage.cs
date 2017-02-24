

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
    public class GuildModificationValidMessage : NetworkMessage
    {
        public override ushort Id => 6323;
        
        
        public string guildName;
        public Types.GuildEmblem guildEmblem;
        
        public GuildModificationValidMessage()
        {
        }
        
        public GuildModificationValidMessage(string guildName, Types.GuildEmblem guildEmblem)
        {
            this.guildName = guildName;
            this.guildEmblem = guildEmblem;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteUTF(guildName);
            guildEmblem.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            guildName = reader.ReadUTF();
            guildEmblem = new Types.GuildEmblem();
            guildEmblem.Deserialize(reader);
        }
        
    }
    
}