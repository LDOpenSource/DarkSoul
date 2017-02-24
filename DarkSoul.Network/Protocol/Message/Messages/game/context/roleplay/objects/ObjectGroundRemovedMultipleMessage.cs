

// Generated on 02/23/2017 16:53:39
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ObjectGroundRemovedMultipleMessage : NetworkMessage
    {
        public override ushort Id => 5944;
        
        
        public IEnumerable<ushort> cells;
        
        public ObjectGroundRemovedMultipleMessage()
        {
        }
        
        public ObjectGroundRemovedMultipleMessage(IEnumerable<ushort> cells)
        {
            this.cells = cells;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)cells.Count());
            foreach (var entry in cells)
            {
                 writer.WriteVarShort((int)entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            cells = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (cells as ushort[])[i] = reader.ReadVarUhShort();
            }
        }
        
    }
    
}