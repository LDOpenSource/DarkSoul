

// Generated on 02/23/2017 16:53:56
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ExchangeStartOkCraftWithInformationMessage : ExchangeStartOkCraftMessage
    {
        public override ushort Id => 5941;
        
        
        public uint skillId;
        
        public ExchangeStartOkCraftWithInformationMessage()
        {
        }
        
        public ExchangeStartOkCraftWithInformationMessage(uint skillId)
        {
            this.skillId = skillId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt((int)skillId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            skillId = reader.ReadVarUhInt();
        }
        
    }
    
}