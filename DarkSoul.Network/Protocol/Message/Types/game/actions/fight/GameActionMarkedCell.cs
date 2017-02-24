

// Generated on 02/23/2017 18:06:37
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class GameActionMarkedCell
    {
        public virtual short TypeId => 85;
        
        public ushort cellId;
        public sbyte zoneSize;
        public int cellColor;
        public sbyte cellsType;
        
        public GameActionMarkedCell()
        {
        }
        
        public GameActionMarkedCell(ushort cellId, sbyte zoneSize, int cellColor, sbyte cellsType)
        {
            this.cellId = cellId;
            this.zoneSize = zoneSize;
            this.cellColor = cellColor;
            this.cellsType = cellsType;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)cellId);
            writer.WriteSByte(zoneSize);
            writer.WriteInt(cellColor);
            writer.WriteSByte(cellsType);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            cellId = reader.ReadVarUhShort();
            zoneSize = reader.ReadSByte();
            cellColor = reader.ReadInt();
            cellsType = reader.ReadSByte();
        }
        
    }
    
}