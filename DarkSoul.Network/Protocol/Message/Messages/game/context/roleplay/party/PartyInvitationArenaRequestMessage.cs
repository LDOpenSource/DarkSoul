

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
    public class PartyInvitationArenaRequestMessage : PartyInvitationRequestMessage
    {
        public override ushort Id => 6283;
        
        
        
        public PartyInvitationArenaRequestMessage()
        {
        }
        
        public PartyInvitationArenaRequestMessage(string name)
         : base(name)
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