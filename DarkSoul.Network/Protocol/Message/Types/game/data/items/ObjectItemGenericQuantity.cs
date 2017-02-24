

// Generated on 02/23/2017 18:06:43
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class ObjectItemGenericQuantity : Item
    {
        public override short TypeId => 483;
        
        public ushort objectGID;
        public uint quantity;
        
        public ObjectItemGenericQuantity()
        {
        }
        
        public ObjectItemGenericQuantity(ushort objectGID, uint quantity)
        {
            this.objectGID = objectGID;
            this.quantity = quantity;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((int)objectGID);
            writer.WriteVarInt((int)quantity);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            objectGID = reader.ReadVarUhShort();
            quantity = reader.ReadVarUhInt();
        }
        
    }
    
}