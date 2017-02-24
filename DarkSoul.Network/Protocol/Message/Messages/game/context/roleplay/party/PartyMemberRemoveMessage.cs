

// Generated on 02/23/2017 16:53:42
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class PartyMemberRemoveMessage : AbstractPartyEventMessage
    {
        public override ushort Id => 5579;
        
        
        public double leavingPlayerId;
        
        public PartyMemberRemoveMessage()
        {
        }
        
        public PartyMemberRemoveMessage(uint partyId, double leavingPlayerId)
         : base(partyId)
        {
            this.leavingPlayerId = leavingPlayerId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(leavingPlayerId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            leavingPlayerId = reader.ReadVarUhLong();
        }
        
    }
    
}