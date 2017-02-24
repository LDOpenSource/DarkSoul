

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
    public class ExchangeRequestMessage : NetworkMessage
    {
        public override ushort Id => 5505;
        
        
        public sbyte exchangeType;
        
        public ExchangeRequestMessage()
        {
        }
        
        public ExchangeRequestMessage(sbyte exchangeType)
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