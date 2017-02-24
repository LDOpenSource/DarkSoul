

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
    public class PartyLeaderUpdateMessage : AbstractPartyEventMessage
    {
        public override ushort Id => 5578;
        
        
        public double partyLeaderId;
        
        public PartyLeaderUpdateMessage()
        {
        }
        
        public PartyLeaderUpdateMessage(uint partyId, double partyLeaderId)
         : base(partyId)
        {
            this.partyLeaderId = partyLeaderId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(partyLeaderId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            partyLeaderId = reader.ReadVarUhLong();
        }
        
    }
    
}