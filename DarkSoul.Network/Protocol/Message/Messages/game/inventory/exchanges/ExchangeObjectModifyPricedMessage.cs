

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
    public class ExchangeObjectModifyPricedMessage : ExchangeObjectMovePricedMessage
    {
        public override ushort Id => 6238;
        
        
        
        public ExchangeObjectModifyPricedMessage()
        {
        }
        
        public ExchangeObjectModifyPricedMessage(uint objectUID, int quantity, double price)
         : base(objectUID, quantity, price)
        {
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
        }
        
    }
    
}