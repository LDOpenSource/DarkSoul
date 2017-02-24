

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
    public class PartyInvitationCancelledForGuestMessage : AbstractPartyMessage
    {
        public override ushort Id => 6256;
        
        
        public double cancelerId;
        
        public PartyInvitationCancelledForGuestMessage()
        {
        }
        
        public PartyInvitationCancelledForGuestMessage(uint partyId, double cancelerId)
         : base(partyId)
        {
            this.cancelerId = cancelerId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(cancelerId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            cancelerId = reader.ReadVarUhLong();
        }
        
    }
    
}