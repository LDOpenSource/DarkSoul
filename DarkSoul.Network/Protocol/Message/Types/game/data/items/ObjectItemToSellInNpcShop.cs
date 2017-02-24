

// Generated on 02/23/2017 18:06:44
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class ObjectItemToSellInNpcShop : ObjectItemMinimalInformation
    {
        public override short TypeId => 352;
        
        public double objectPrice;
        public string buyCriterion;
        
        public ObjectItemToSellInNpcShop()
        {
        }
        
        public ObjectItemToSellInNpcShop(ushort objectGID, IEnumerable<Types.ObjectEffect> effects, double objectPrice, string buyCriterion)
         : base(objectGID, effects)
        {
            this.objectPrice = objectPrice;
            this.buyCriterion = buyCriterion;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(objectPrice);
            writer.WriteUTF(buyCriterion);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            objectPrice = reader.ReadVarUhLong();
            buyCriterion = reader.ReadUTF();
        }
        
    }
    
}