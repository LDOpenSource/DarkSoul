

// Generated on 02/23/2017 18:06:37
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class GameServerInformations
    {
        public virtual short TypeId => 25;
        
        public ushort id;
        public sbyte type;
        public sbyte status;
        public sbyte completion;
        public bool isSelectable;
        public sbyte charactersCount;
        public sbyte charactersSlots;
        public double date;
        
        public GameServerInformations()
        {
        }
        
        public GameServerInformations(ushort id, sbyte type, sbyte status, sbyte completion, bool isSelectable, sbyte charactersCount, sbyte charactersSlots, double date)
        {
            this.id = id;
            this.type = type;
            this.status = status;
            this.completion = completion;
            this.isSelectable = isSelectable;
            this.charactersCount = charactersCount;
            this.charactersSlots = charactersSlots;
            this.date = date;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)id);
            writer.WriteSByte(type);
            writer.WriteSByte(status);
            writer.WriteSByte(completion);
            writer.WriteBoolean(isSelectable);
            writer.WriteSByte(charactersCount);
            writer.WriteSByte(charactersSlots);
            writer.WriteDouble(date);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            id = reader.ReadVarUhShort();
            type = reader.ReadSByte();
            status = reader.ReadSByte();
            completion = reader.ReadSByte();
            isSelectable = reader.ReadBoolean();
            charactersCount = reader.ReadSByte();
            charactersSlots = reader.ReadSByte();
            date = reader.ReadDouble();
        }
        
    }
    
}