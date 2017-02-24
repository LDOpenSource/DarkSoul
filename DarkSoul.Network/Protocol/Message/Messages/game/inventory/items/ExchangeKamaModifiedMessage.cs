

// Generated on 02/23/2017 16:53:57
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ExchangeKamaModifiedMessage : ExchangeObjectMessage
    {
        public override ushort Id => 5521;
        
        
        public double quantity;
        
        public ExchangeKamaModifiedMessage()
        {
        }
        
        public ExchangeKamaModifiedMessage(bool remote, double quantity)
         : base(remote)
        {
            this.quantity = quantity;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(quantity);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            quantity = reader.ReadVarUhLong();
        }
        
    }
    
}