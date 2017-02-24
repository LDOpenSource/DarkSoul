

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
    public class PartyFollowMemberRequestMessage : AbstractPartyMessage
    {
        public override ushort Id => 5577;
        
        
        public double playerId;
        
        public PartyFollowMemberRequestMessage()
        {
        }
        
        public PartyFollowMemberRequestMessage(uint partyId, double playerId)
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