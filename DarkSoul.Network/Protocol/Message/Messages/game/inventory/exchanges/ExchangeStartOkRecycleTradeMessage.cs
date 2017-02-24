

// Generated on 02/23/2017 16:53:56
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ExchangeStartOkRecycleTradeMessage : NetworkMessage
    {
        public override ushort Id => 6600;
        
        
        public short percentToPrism;
        public short percentToPlayer;
        
        public ExchangeStartOkRecycleTradeMessage()
        {
        }
        
        public ExchangeStartOkRecycleTradeMessage(short percentToPrism, short percentToPlayer)
        {
            this.percentToPrism = percentToPrism;
            this.percentToPlayer = percentToPlayer;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort(percentToPrism);
            writer.WriteShort(percentToPlayer);
        }
        
        public override void Deserialize(IReader reader)
        {
            percentToPrism = reader.ReadShort();
            percentToPlayer = reader.ReadShort();
        }
        
    }
    
}