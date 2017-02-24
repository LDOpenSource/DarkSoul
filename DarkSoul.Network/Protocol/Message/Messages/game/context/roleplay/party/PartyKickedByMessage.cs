

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
    public class PartyKickedByMessage : AbstractPartyMessage
    {
        public override ushort Id => 5590;
        
        
        public double kickerId;
        
        public PartyKickedByMessage()
        {
        }
        
        public PartyKickedByMessage(uint partyId, double kickerId)
         : base(partyId)
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