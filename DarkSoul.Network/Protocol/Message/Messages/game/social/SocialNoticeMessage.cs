

// Generated on 02/23/2017 16:54:03
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class SocialNoticeMessage : NetworkMessage
    {
        public override ushort Id => 6688;
        
        
        public string content;
        public int timestamp;
        public double memberId;
        public string memberName;
        
        public SocialNoticeMessage()
        {
        }
        
        public SocialNoticeMessage(string content, int timestamp, double memberId, string memberName)
        {
            this.content = content;
            this.timestamp = timestamp;
            this.memberId = memberId;
            this.memberName = memberName;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteUTF(content);
            writer.WriteInt(timestamp);
            writer.WriteVarLong(memberId);
            writer.WriteUTF(memberName);
        }
        
        public override void Deserialize(IReader reader)
        {
            content = reader.ReadUTF();
            timestamp = reader.ReadInt();
            memberId = reader.ReadVarUhLong();
            memberName = reader.ReadUTF();
        }
        
    }
    
}