

// Generated on 02/23/2017 16:54:03
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ContactLookRequestByIdMessage : ContactLookRequestMessage
    {
        public override ushort Id => 5935;
        
        
        public double playerId;
        
        public ContactLookRequestByIdMessage()
        {
        }
        
        public ContactLookRequestByIdMessage(byte requestId, sbyte contactType, double playerId)
         : base(requestId, contactType)
        {
            this.playerId = playerId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(playerId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            playerId = reader.ReadVarUhLong();
        }
        
    }
    
}