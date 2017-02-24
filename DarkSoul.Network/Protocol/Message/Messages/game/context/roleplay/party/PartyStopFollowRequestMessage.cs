

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
    public class PartyStopFollowRequestMessage : AbstractPartyMessage
    {
        public override ushort Id => 5574;
        
        
        public double playerId;
        
        public PartyStopFollowRequestMessage()
        {
        }
        
        public PartyStopFollowRequestMessage(uint partyId, double playerId)
         : base(partyId)
        {
            this.playerId = playerId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(playerId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            playerId = reader.ReadVarUhLong();
        }
        
    }
    
}