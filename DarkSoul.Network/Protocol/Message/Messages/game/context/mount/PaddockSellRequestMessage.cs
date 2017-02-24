

// Generated on 02/23/2017 16:53:33
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class PaddockSellRequestMessage : NetworkMessage
    {
        public override ushort Id => 5953;
        
        
        public double price;
        public bool forSale;
        
        public PaddockSellRequestMessage()
        {
        }
        
        public PaddockSellRequestMessage(double price, bool forSale)
        {
            this.price = price;
            this.forSale = forSale;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarLong(price);
            writer.WriteBoolean(forSale);
        }
        
        public override void Deserialize(IReader reader)
        {
            price = reader.ReadVarUhLong();
            forSale = reader.ReadBoolean();
        }
        
    }
    
}