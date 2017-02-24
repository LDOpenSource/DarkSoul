

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
    public class ExchangeStartOkNpcTradeMessage : NetworkMessage
    {
        public override ushort Id => 5785;
        
        
        public double npcId;
        
        public ExchangeStartOkNpcTradeMessage()
        {
        }
        
        public ExchangeStartOkNpcTradeMessage(double npcId)
        {
            this.npcId = npcId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteDouble(npcId);
        }
        
        public override void Deserialize(IReader reader)
        {
            npcId = reader.ReadDouble();
        }
        
    }
    
}