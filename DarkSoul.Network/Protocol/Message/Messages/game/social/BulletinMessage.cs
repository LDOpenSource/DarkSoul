

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
    public class BulletinMessage : SocialNoticeMessage
    {
        public override ushort Id => 6695;
        
        
        public int lastNotifiedTimestamp;
        
        public BulletinMessage()
        {
        }
        
        public BulletinMessage(string content, int timestamp, double memberId, string memberName, int lastNotifiedTimestamp)
         : base(content, timestamp, memberId, memberName)
        {
            this.lastNotifiedTimestamp = lastNotifiedTimestamp;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteInt(lastNotifiedTimestamp);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            lastNotifiedTimestamp = reader.ReadInt();
        }
        
    }
    
}