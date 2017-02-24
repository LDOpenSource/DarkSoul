

// Generated on 02/23/2017 16:53:55
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ExchangeReplyTaxVendorMessage : NetworkMessage
    {
        public override ushort Id => 5787;
        
        
        public double objectValue;
        public double totalTaxValue;
        
        public ExchangeReplyTaxVendorMessage()
        {
        }
        
        public ExchangeReplyTaxVendorMessage(double objectValue, double totalTaxValue)
        {
            this.objectValue = objectValue;
            this.totalTaxValue = totalTaxValue;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarLong(objectValue);
            writer.WriteVarLong(totalTaxValue);
        }
        
        public override void Deserialize(IReader reader)
        {
            objectValue = reader.ReadVarUhLong();
            totalTaxValue = reader.ReadVarUhLong();
        }
        
    }
    
}