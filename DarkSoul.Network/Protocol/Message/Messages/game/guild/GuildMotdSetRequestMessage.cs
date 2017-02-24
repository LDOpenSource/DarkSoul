

// Generated on 02/23/2017 16:53:49
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GuildMotdSetRequestMessage : SocialNoticeSetRequestMessage
    {
        public override ushort Id => 6588;
        
        
        public string content;
        
        public GuildMotdSetRequestMessage()
        {
        }
        
        public GuildMotdSetRequestMessage(string content)
        {
            this.content = content;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(content);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            content = reader.ReadUTF();
        }
        
    }
    
}