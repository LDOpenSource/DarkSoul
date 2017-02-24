

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
    public class GuildModificationEmblemValidMessage : NetworkMessage
    {
        public override ushort Id => 6328;
        
        
        public Types.GuildEmblem guildEmblem;
        
        public GuildModificationEmblemValidMessage()
        {
        }
        
        public GuildModificationEmblemValidMessage(Types.GuildEmblem guildEmblem)
        {
            this.guildEmblem = guildEmblem;
        }
        
        public override void Serialize(IWriter writer)
        {
            guildEmblem.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            guildEmblem = new Types.GuildEmblem();
            guildEmblem.Deserialize(reader);
        }
        
    }
    
}