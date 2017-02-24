

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
    public class PartyNewGuestMessage : AbstractPartyEventMessage
    {
        public override ushort Id => 6260;
        
        
        public Types.PartyGuestInformations guest;
        
        public PartyNewGuestMessage()
        {
        }
        
        public PartyNewGuestMessage(uint partyId, Types.PartyGuestInformations guest)
         : base(partyId)
        {
            this.guest = guest;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            guest.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            guest = new Types.PartyGuestInformations();
            guest.Deserialize(reader);
        }
        
    }
    
}