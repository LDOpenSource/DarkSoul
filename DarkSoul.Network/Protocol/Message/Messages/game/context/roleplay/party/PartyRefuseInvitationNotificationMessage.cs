

// Generated on 02/23/2017 16:53:43
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class PartyRefuseInvitationNotificationMessage : AbstractPartyEventMessage
    {
        public override ushort Id => 5596;
        
        
        public double guestId;
        
        public PartyRefuseInvitationNotificationMessage()
        {
        }
        
        public PartyRefuseInvitationNotificationMessage(uint partyId, double guestId)
         : base(partyId)
        {
            this.guestId = guestId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(guestId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            guestId = reader.ReadVarUhLong();
        }
        
    }
    
}