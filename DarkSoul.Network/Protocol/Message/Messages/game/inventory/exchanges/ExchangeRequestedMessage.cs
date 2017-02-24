

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
    public class ExchangeRequestedMessage : NetworkMessage
    {
        public override ushort Id => 5522;
        
        
        public sbyte exchangeType;
        
        public ExchangeRequestedMessage()
        {
        }
        
        public ExchangeRequestedMessage(sbyte exchangeType)
        {
            this.exchangeType = exchangeType;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(exchangeType);
        }
        
        public override void Deserialize(IReader reader)
        {
            exchangeType = reader.ReadSByte();
        }
        
    }
    
}