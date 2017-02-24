

// Generated on 02/23/2017 16:53:52
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ExchangeCraftPaymentModificationRequestMessage : NetworkMessage
    {
        public override ushort Id => 6579;
        
        
        public double quantity;
        
        public ExchangeCraftPaymentModificationRequestMessage()
        {
        }
        
        public ExchangeCraftPaymentModificationRequestMessage(double quantity)
        {
            this.quantity = quantity;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarLong(quantity);
        }
        
        public override void Deserialize(IReader reader)
        {
            quantity = reader.ReadVarUhLong();
        }
        
    }
    
}