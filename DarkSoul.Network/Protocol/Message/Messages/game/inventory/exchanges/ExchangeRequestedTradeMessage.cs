

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
    public class ExchangeRequestedTradeMessage : ExchangeRequestedMessage
    {
        public override ushort Id => 5523;
        
        
        public double source;
        public double target;
        
        public ExchangeRequestedTradeMessage()
        {
        }
        
        public ExchangeRequestedTradeMessage(sbyte exchangeType, double source, double target)
         : base(exchangeType)
        {
            this.source = source;
            this.target = target;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(source);
            writer.WriteVarLong(target);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            source = reader.ReadVarUhLong();
            target = reader.ReadVarUhLong();
        }
        
    }
    
}