

// Generated on 02/23/2017 18:06:43
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class ObjectItemInformationWithQuantity : ObjectItemMinimalInformation
    {
        public override short TypeId => 387;
        
        public uint quantity;
        
        public ObjectItemInformationWithQuantity()
        {
        }
        
        public ObjectItemInformationWithQuantity(ushort objectGID, IEnumerable<Types.ObjectEffect> effects, uint quantity)
         : base(objectGID, effects)
        {
            this.quantity = quantity;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt((int)quantity);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            quantity = reader.ReadVarUhInt();
        }
        
    }
    
}