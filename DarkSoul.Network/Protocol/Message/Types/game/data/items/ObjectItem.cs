

// Generated on 02/23/2017 18:06:43
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class ObjectItem : Item
    {
        public override short TypeId => 37;
        
        public byte position;
        public ushort objectGID;
        public IEnumerable<Types.ObjectEffect> effects;
        public uint objectUID;
        public uint quantity;
        
        public ObjectItem()
        {
        }
        
        public ObjectItem(byte position, ushort objectGID, IEnumerable<Types.ObjectEffect> effects, uint objectUID, uint quantity)
        {
            this.position = position;
            this.objectGID = objectGID;
            this.effects = effects;
            this.objectUID = objectUID;
            this.quantity = quantity;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteByte(position);
            writer.WriteVarShort((int)objectGID);
            writer.WriteShort((short)effects.Count());
            foreach (var entry in effects)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteVarInt((int)objectUID);
            writer.WriteVarInt((int)quantity);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            position = reader.ReadByte();
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
        }
        
    }
    
}