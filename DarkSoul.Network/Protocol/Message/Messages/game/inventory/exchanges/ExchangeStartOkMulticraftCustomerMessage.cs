

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
    public class ExchangeStartOkMulticraftCustomerMessage : NetworkMessage
    {
        public override ushort Id => 5817;
        
        
        public uint skillId;
        public byte crafterJobLevel;
        
        public ExchangeStartOkMulticraftCustomerMessage()
        {
        }
        
        public ExchangeStartOkMulticraftCustomerMessage(uint skillId, byte crafterJobLevel)
        {
            this.skillId = skillId;
            this.crafterJobLevel = crafterJobLevel;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)skillId);
            writer.WriteByte(crafterJobLevel);
        }
        
        public override void Deserialize(IReader reader)
        {
            skillId = reader.ReadVarUhInt();
            crafterJobLevel = reader.ReadByte();
        }
        
    }
    
}