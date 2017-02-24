

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
    public class AllianceBulletinSetErrorMessage : SocialNoticeSetErrorMessage
    {
        public override ushort Id => 6692;
        
        
        
        public AllianceBulletinSetErrorMessage()
        {
        }
        
        public AllianceBulletinSetErrorMessage(sbyte reason)
         : base(reason)
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