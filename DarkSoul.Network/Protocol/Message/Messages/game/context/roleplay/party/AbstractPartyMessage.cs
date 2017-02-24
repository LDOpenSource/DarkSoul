

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
    public class AbstractPartyMessage : NetworkMessage
    {
        public override ushort Id => 6274;
        
        
        public uint partyId;
        
        public AbstractPartyMessage()
        {
        }
        
        public AbstractPartyMessage(uint partyId)
        {
            this.partyId = partyId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)partyId);
        }
        
        public override void Deserialize(IReader reader)
        {
            partyId = reader.ReadVarUhInt();
        }
        
    }
    
}