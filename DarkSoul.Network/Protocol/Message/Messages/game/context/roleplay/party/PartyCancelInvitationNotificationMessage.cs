

// Generated on 02/23/2017 16:53:40
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class PartyCancelInvitationNotificationMessage : AbstractPartyEventMessage
    {
        public override ushort Id => 6251;
        
        
        public double cancelerId;
        public double guestId;
        
        public PartyCancelInvitationNotificationMessage()
        {
        }
        
        public PartyCancelInvitationNotificationMessage(uint partyId, double cancelerId, double guestId)
         : base(partyId)
        {
            this.cancelerId = cancelerId;
            this.guestId = guestId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(cancelerId);
            writer.WriteVarLong(guestId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            cancelerId = reader.ReadVarUhLong();
            guestId = reader.ReadVarUhLong();
        }
        
    }
    
}