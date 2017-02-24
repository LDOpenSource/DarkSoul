

// Generated on 02/23/2017 16:53:41
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class PartyFollowThisMemberRequestMessage : PartyFollowMemberRequestMessage
    {
        public override ushort Id => 5588;
        
        
        public bool enabled;
        
        public PartyFollowThisMemberRequestMessage()
        {
        }
        
        public PartyFollowThisMemberRequestMessage(uint partyId, double playerId, bool enabled)
         : base(partyId, playerId)
        {
            this.enabled = enabled;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteBoolean(enabled);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            enabled = reader.ReadBoolean();
        }
        
    }
    
}