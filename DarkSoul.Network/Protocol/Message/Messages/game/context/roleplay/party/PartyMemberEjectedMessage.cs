

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
    public class PartyMemberEjectedMessage : PartyMemberRemoveMessage
    {
        public override ushort Id => 6252;
        
        
        public double kickerId;
        
        public PartyMemberEjectedMessage()
        {
        }
        
        public PartyMemberEjectedMessage(uint partyId, double leavingPlayerId, double kickerId)
         : base(partyId, leavingPlayerId)
        {
            this.kickerId = kickerId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(kickerId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            kickerId = reader.ReadVarUhLong();
        }
        
    }
    
}