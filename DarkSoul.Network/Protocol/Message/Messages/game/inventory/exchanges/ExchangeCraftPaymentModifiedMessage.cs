

// Generated on 02/23/2017 16:53:53
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ExchangeCraftPaymentModifiedMessage : NetworkMessage
    {
        public override ushort Id => 6578;
        
        
        public double goldSum;
        
        public ExchangeCraftPaymentModifiedMessage()
        {
        }
        
        public ExchangeCraftPaymentModifiedMessage(double goldSum)
        {
            this.goldSum = goldSum;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarLong(goldSum);
        }
        
        public override void Deserialize(IReader reader)
        {
            goldSum = reader.ReadVarUhLong();
        }
        
    }
    
}