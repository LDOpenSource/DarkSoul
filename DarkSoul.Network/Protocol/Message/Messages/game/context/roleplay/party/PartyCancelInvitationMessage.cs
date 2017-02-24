

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
    public class PartyCancelInvitationMessage : AbstractPartyMessage
    {
        public override ushort Id => 6254;
        
        
        public double guestId;
        
        public PartyCancelInvitationMessage()
        {
        }
        
        public PartyCancelInvitationMessage(uint partyId, double guestId)
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