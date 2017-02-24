

// Generated on 02/23/2017 18:06:37
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class GameActionMark
    {
        public virtual short TypeId => 351;
        
        public double markAuthorId;
        public sbyte markTeamId;
        public int markSpellId;
        public short markSpellLevel;
        public short markId;
        public sbyte markType;
        public short markimpactCell;
        public IEnumerable<Types.GameActionMarkedCell> cells;
        public bool active;
        
        public GameActionMark()
        {
        }
        
        public GameActionMark(double markAuthorId, sbyte markTeamId, int markSpellId, short markSpellLevel, short markId, sbyte markType, short markimpactCell, IEnumerable<Types.GameActionMarkedCell> cells, bool active)
        {
            this.markAuthorId = markAuthorId;
            this.markTeamId = markTeamId;
            this.markSpellId = markSpellId;
            this.markSpellLevel = markSpellLevel;
            this.markId = markId;
            this.markType = markType;
            this.markimpactCell = markimpactCell;
            this.cells = cells;
            this.active = active;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteDouble(markAuthorId);
            writer.WriteSByte(markTeamId);
            writer.WriteInt(markSpellId);
            writer.WriteShort(markSpellLevel);
            writer.WriteShort(markId);
            writer.WriteSByte(markType);
            writer.WriteShort(markimpactCell);
            writer.WriteShort((short)cells.Count());
            foreach (var entry in cells)
            {
                 entry.Serialize(writer);
            }
            writer.WriteBoolean(active);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            markAuthorId = reader.ReadDouble();
            markTeamId = reader.ReadSByte();
            markSpellId = reader.ReadInt();
            markSpellLevel = reader.ReadShort();
            markId = reader.ReadShort();
            markType = reader.ReadSByte();
            markimpactCell = reader.ReadShort();
            var limit = reader.ReadUShort();
            cells = new Types.GameActionMarkedCell[limit];
            for (int i = 0; i < limit; i++)
            {
                 (cells as Types.GameActionMarkedCell[])[i] = new Types.GameActionMarkedCell();
                 (cells as Types.GameActionMarkedCell[])[i].Deserialize(reader);
            }
            active = reader.ReadBoolean();
        }
        
    }
    
}