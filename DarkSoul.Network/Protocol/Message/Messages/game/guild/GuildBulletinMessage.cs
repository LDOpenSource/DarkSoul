

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
    public class GuildBulletinMessage : BulletinMessage
    {
        public override ushort Id => 6689;
        
        
        
        public GuildBulletinMessage()
        {
        }
        
        public GuildBulletinMessage(string content, int timestamp, double memberId, string memberName, int lastNotifiedTimestamp)
         : base(content, timestamp, memberId, memberName, lastNotifiedTimestamp)
        {
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
        }
        
    }
    
}