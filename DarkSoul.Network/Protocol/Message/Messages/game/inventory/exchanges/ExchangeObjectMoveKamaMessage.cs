

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
    public class ExchangeObjectMoveKamaMessage : NetworkMessage
    {
        public override ushort Id => 5520;
        
        
        public double quantity;
        
        public ExchangeObjectMoveKamaMessage()
        {
        }
        
        public ExchangeObjectMoveKamaMessage(double quantity)
        {
            this.quantity = quantity;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarLong(quantity);
        }
        
        public override void Deserialize(IReader reader)
        {
            quantity = reader.ReadVarLong();
        }
        
    }
    
}