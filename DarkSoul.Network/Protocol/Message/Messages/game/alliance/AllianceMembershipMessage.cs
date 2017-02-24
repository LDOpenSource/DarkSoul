

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
    public class AllianceMembershipMessage : AllianceJoinedMessage
    {
        public override ushort Id => 6390;
        
        
        
        public AllianceMembershipMessage()
        {
        }
        
        public AllianceMembershipMessage(Types.AllianceInformations allianceInfo, bool enabled, uint leadingGuildId)
         : base(allianceInfo, enabled, leadingGuildId)
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