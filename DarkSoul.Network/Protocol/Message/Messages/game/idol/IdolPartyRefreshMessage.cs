

// Generated on 02/23/2017 16:53:50
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class IdolPartyRefreshMessage : NetworkMessage
    {
        public override ushort Id => 6583;
        
        
        public Types.PartyIdol partyIdol;
        
        public IdolPartyRefreshMessage()
        {
        }
        
        public IdolPartyRefreshMessage(Types.PartyIdol partyIdol)
        {
            this.partyIdol = partyIdol;
        }
        
        public override void Serialize(IWriter writer)
        {
            partyIdol.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            partyIdol = new Types.PartyIdol();
            partyIdol.Deserialize(reader);
        }
        
    }
    
}