

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
    public class PartyModifiableStatusMessage : AbstractPartyMessage
    {
        public override ushort Id => 6277;
        
        
        public bool enabled;
        
        public PartyModifiableStatusMessage()
        {
        }
        
        public PartyModifiableStatusMessage(uint partyId, bool enabled)
         : base(partyId)
        {
            this.enabled = enabled;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteBoolean(enabled);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            enabled = reader.ReadBoolean();
        }
        
    }
    
}