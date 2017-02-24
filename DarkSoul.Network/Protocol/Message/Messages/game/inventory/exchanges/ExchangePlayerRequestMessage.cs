

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
    public class ExchangePlayerRequestMessage : ExchangeRequestMessage
    {
        public override ushort Id => 5773;
        
        
        public double target;
        
        public ExchangePlayerRequestMessage()
        {
        }
        
        public ExchangePlayerRequestMessage(sbyte exchangeType, double target)
         : base(exchangeType)
        {
            this.target = target;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(target);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            target = reader.ReadVarUhLong();
        }
        
    }
    
}