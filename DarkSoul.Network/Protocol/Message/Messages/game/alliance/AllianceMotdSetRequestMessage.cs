

// Generated on 02/23/2017 16:53:22
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class AllianceMotdSetRequestMessage : SocialNoticeSetRequestMessage
    {
        public override ushort Id => 6687;
        
        
        public string content;
        
        public AllianceMotdSetRequestMessage()
        {
        }
        
        public AllianceMotdSetRequestMessage(string content)
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