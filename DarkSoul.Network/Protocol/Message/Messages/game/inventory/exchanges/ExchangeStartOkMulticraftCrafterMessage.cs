

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
    public class ExchangeStartOkMulticraftCrafterMessage : NetworkMessage
    {
        public override ushort Id => 5818;
        
        
        public uint skillId;
        
        public ExchangeStartOkMulticraftCrafterMessage()
        {
        }
        
        public ExchangeStartOkMulticraftCrafterMessage(uint skillId)
        {
            this.skillId = skillId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)skillId);
        }
        
        public override void Deserialize(IReader reader)
        {
            skillId = reader.ReadVarUhInt();
        }
        
    }
    
}