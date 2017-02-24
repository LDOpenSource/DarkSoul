

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
    public class PartyPledgeLoyaltyRequestMessage : AbstractPartyMessage
    {
        public override ushort Id => 6269;
        
        
        public bool loyal;
        
        public PartyPledgeLoyaltyRequestMessage()
        {
        }
        
        public PartyPledgeLoyaltyRequestMessage(uint partyId, bool loyal)
         : base(partyId)
        {
            this.loyal = loyal;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteBoolean(loyal);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            loyal = reader.ReadBoolean();
        }
        
    }
    
}