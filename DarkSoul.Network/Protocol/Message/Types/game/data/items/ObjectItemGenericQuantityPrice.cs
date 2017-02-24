

// Generated on 02/23/2017 18:06:43
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class ObjectItemGenericQuantityPrice : ObjectItemGenericQuantity
    {
        public override short TypeId => 494;
        
        public double price;
        
        public ObjectItemGenericQuantityPrice()
        {
        }
        
        public ObjectItemGenericQuantityPrice(ushort objectGID, uint quantity, double price)
         : base(objectGID, quantity)
        {
            this.price = price;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(price);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            price = reader.ReadVarUhLong();
        }
        
    }
    
}