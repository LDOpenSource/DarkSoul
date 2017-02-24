

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
    public class ExchangeObjectMovePricedMessage : ExchangeObjectMoveMessage
    {
        public override ushort Id => 5514;
        
        
        public double price;
        
        public ExchangeObjectMovePricedMessage()
        {
        }
        
        public ExchangeObjectMovePricedMessage(uint objectUID, int quantity, double price)
         : base(objectUID, quantity)
        {
            this.price = price;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(price);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            price = reader.ReadVarUhLong();
        }
        
    }
    
}