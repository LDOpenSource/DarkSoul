

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
    public class PartyRestrictedMessage : AbstractPartyMessage
    {
        public override ushort Id => 6175;
        
        
        public bool restricted;
        
        public PartyRestrictedMessage()
        {
        }
        
        public PartyRestrictedMessage(uint partyId, bool restricted)
         : base(partyId)
        {
            this.restricted = restricted;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteBoolean(restricted);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            restricted = reader.ReadBoolean();
        }
        
    }
    
}