

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
    public class PartyNewMemberMessage : PartyUpdateMessage
    {
        public override ushort Id => 6306;
        
        
        
        public PartyNewMemberMessage()
        {
        }
        
        public PartyNewMemberMessage(uint partyId, Types.PartyMemberInformations memberInformations)
         : base(partyId, memberInformations)
        {
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
        }
        
    }
    
}