

// Generated on 02/23/2017 18:06:44
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class ObjectItemToSell : Item
    {
        public override short TypeId => 120;
        
        public ushort objectGID;
        public IEnumerable<Types.ObjectEffect> effects;
        public uint objectUID;
        public uint quantity;
        public double objectPrice;
        
        public ObjectItemToSell()
        {
        }
        
        public ObjectItemToSell(ushort objectGID, IEnumerable<Types.ObjectEffect> effects, uint objectUID, uint quantity, double objectPrice)
        {
            this.objectGID = objectGID;
            this.effects = effects;
            this.objectUID = objectUID;
            this.quantity = quantity;
            this.objectPrice = objectPrice;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((int)objectGID);
            writer.WriteShort((short)effects.Count());
            foreach (var entry in effects)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteVarInt((int)objectUID);
            writer.WriteVarInt((int)quantity);
            writer.WriteVarLong(objectPrice);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            objectGID = reader.ReadVarUhShort();
            var limit = reader.ReadUShort();
            effects = new Types.ObjectEffect[limit];
            for (int i = 0; i < limit; i++)
            {
                 (effects as Types.ObjectEffect[])[i] = ProtocolTypeManager.GetInstance<Types.ObjectEffect>(reader.ReadUShort());
                 (effects as Types.ObjectEffect[])[i].Deserialize(reader);
            }
            objectUID = reader.ReadVarUhInt();
            quantity = reader.ReadVarUhInt();
            objectPrice = reader.ReadVarUhLong();
        }
        
    }
    
}