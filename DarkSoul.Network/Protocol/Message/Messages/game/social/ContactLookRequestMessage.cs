

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
    public class ContactLookRequestMessage : NetworkMessage
    {
        public override ushort Id => 5932;
        
        
        public byte requestId;
        public sbyte contactType;
        
        public ContactLookRequestMessage()
        {
        }
        
        public ContactLookRequestMessage(byte requestId, sbyte contactType)
        {
            this.requestId = requestId;
            this.contactType = contactType;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteByte(requestId);
            writer.WriteSByte(contactType);
        }
        
        public override void Deserialize(IReader reader)
        {
            requestId = reader.ReadByte();
            contactType = reader.ReadSByte();
        }
        
    }
    
}