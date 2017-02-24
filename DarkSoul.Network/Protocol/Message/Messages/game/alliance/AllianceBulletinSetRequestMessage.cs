

// Generated on 02/23/2017 16:53:21
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class AllianceBulletinSetRequestMessage : SocialNoticeSetRequestMessage
    {
        public override ushort Id => 6693;
        
        
        public string content;
        public bool notifyMembers;
        
        public AllianceBulletinSetRequestMessage()
        {
        }
        
        public AllianceBulletinSetRequestMessage(string content, bool notifyMembers)
        {
            this.content = content;
            this.notifyMembers = notifyMembers;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(content);
            writer.WriteBoolean(notifyMembers);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            content = reader.ReadUTF();
            notifyMembers = reader.ReadBoolean();
        }
        
    }
    
}