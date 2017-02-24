

// Generated on 02/23/2017 18:06:46
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class PaddockBuyableInformations
    {
        public virtual short TypeId => 130;
        
        public double price;
        public bool locked;
        
        public PaddockBuyableInformations()
        {
        }
        
        public PaddockBuyableInformations(double price, bool locked)
        {
            this.price = price;
            this.locked = locked;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteVarLong(price);
            writer.WriteBoolean(locked);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            price = reader.ReadVarUhLong();
            locked = reader.ReadBoolean();
        }
        
    }
    
}