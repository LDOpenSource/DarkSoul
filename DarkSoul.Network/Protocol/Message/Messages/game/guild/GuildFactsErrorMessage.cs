

// Generated on 02/23/2017 16:53:47
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GuildFactsErrorMessage : NetworkMessage
    {
        public override ushort Id => 6424;
        
        
        public uint guildId;
        
        public GuildFactsErrorMessage()
        {
        }
        
        public GuildFactsErrorMessage(uint guildId)
        {
            this.guildId = guildId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)guildId);
        }
        
        public override void Deserialize(IReader reader)
        {
            guildId = reader.ReadVarUhInt();
        }
        
    }
    
}