

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
    public class GuildModificationNameValidMessage : NetworkMessage
    {
        public override ushort Id => 6327;
        
        
        public string guildName;
        
        public GuildModificationNameValidMessage()
        {
        }
        
        public GuildModificationNameValidMessage(string guildName)
        {
            this.guildName = guildName;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteUTF(guildName);
        }
        
        public override void Deserialize(IReader reader)
        {
            guildName = reader.ReadUTF();
        }
        
    }
    
}