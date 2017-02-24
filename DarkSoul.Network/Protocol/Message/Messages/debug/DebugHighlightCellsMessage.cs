

// Generated on 02/23/2017 16:53:17
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class DebugHighlightCellsMessage : NetworkMessage
    {
        public override ushort Id => 2001;
        
        
        public int color;
        public IEnumerable<ushort> cells;
        
        public DebugHighlightCellsMessage()
        {
        }
        
        public DebugHighlightCellsMessage(int color, IEnumerable<ushort> cells)
        {
            this.color = color;
            this.cells = cells;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteInt(color);
            writer.WriteShort((short)cells.Count());
            foreach (var entry in cells)
            {
                 writer.WriteVarShort((int)entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            color = reader.ReadInt();
            var limit = reader.ReadUShort();
            cells = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (cells as ushort[])[i] = reader.ReadVarUhShort();
            }
        }
        
    }
    
}