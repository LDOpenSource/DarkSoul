

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
    public class PartyCannotJoinErrorMessage : AbstractPartyMessage
    {
        public override ushort Id => 5583;
        
        
        public sbyte reason;
        
        public PartyCannotJoinErrorMessage()
        {
        }
        
        public PartyCannotJoinErrorMessage(uint partyId, sbyte reason)
         : base(partyId)
        {
            this.reason = reason;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSByte(reason);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            reason = reader.ReadSByte();
        }
        
    }
    
}