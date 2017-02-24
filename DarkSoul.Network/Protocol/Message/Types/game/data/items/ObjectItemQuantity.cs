

// Generated on 02/23/2017 18:06:44
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class ObjectItemQuantity : Item
    {
        public override short TypeId => 119;
        
        public uint objectUID;
        public uint quantity;
        
        public ObjectItemQuantity()
        {
        }
        
        public ObjectItemQuantity(uint objectUID, uint quantity)
        {
            this.objectUID = objectUID;
            this.quantity = quantity;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt((int)objectUID);
            writer.WriteVarInt((int)quantity);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            objectUID = reader.ReadVarUhInt();
            quantity = reader.ReadVarUhInt();
        }
        
    }
    
}