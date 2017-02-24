

// Generated on 02/23/2017 18:06:44
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class ObjectItemToSellInBid : ObjectItemToSell
    {
        public override short TypeId => 164;
        
        public int unsoldDelay;
        
        public ObjectItemToSellInBid()
        {
        }
        
        public ObjectItemToSellInBid(ushort objectGID, IEnumerable<Types.ObjectEffect> effects, uint objectUID, uint quantity, double objectPrice, int unsoldDelay)
         : base(objectGID, effects, objectUID, quantity, objectPrice)
        {
            this.unsoldDelay = unsoldDelay;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteInt(unsoldDelay);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            unsoldDelay = reader.ReadInt();
        }
        
    }
    
}