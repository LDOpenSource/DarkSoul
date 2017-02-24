

// Generated on 02/23/2017 16:53:54
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ExchangeOkMultiCraftMessage : NetworkMessage
    {
        public override ushort Id => 5768;
        
        
        public double initiatorId;
        public double otherId;
        public sbyte role;
        
        public ExchangeOkMultiCraftMessage()
        {
        }
        
        public ExchangeOkMultiCraftMessage(double initiatorId, double otherId, sbyte role)
        {
            this.initiatorId = initiatorId;
            this.otherId = otherId;
            this.role = role;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarLong(initiatorId);
            writer.WriteVarLong(otherId);
            writer.WriteSByte(role);
        }
        
        public override void Deserialize(IReader reader)
        {
            initiatorId = reader.ReadVarUhLong();
            otherId = reader.ReadVarUhLong();
            role = reader.ReadSByte();
        }
        
    }
    
}