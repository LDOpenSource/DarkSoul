

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
    public class ContactLookRequestByNameMessage : ContactLookRequestMessage
    {
        public override ushort Id => 5933;
        
        
        public string playerName;
        
        public ContactLookRequestByNameMessage()
        {
        }
        
        public ContactLookRequestByNameMessage(byte requestId, sbyte contactType, string playerName)
         : base(requestId, contactType)
        {
            this.playerName = playerName;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(playerName);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            playerName = reader.ReadUTF();
        }
        
    }
    
}