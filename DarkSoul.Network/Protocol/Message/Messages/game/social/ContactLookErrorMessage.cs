

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
    public class ContactLookErrorMessage : NetworkMessage
    {
        public override ushort Id => 6045;
        
        
        public uint requestId;
        
        public ContactLookErrorMessage()
        {
        }
        
        public ContactLookErrorMessage(uint requestId)
        {
            this.requestId = requestId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)requestId);
        }
        
        public override void Deserialize(IReader reader)
        {
            requestId = reader.ReadVarUhInt();
        }
        
    }
    
}