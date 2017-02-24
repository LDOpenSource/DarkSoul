

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
    public class ObjectGroundListAddedMessage : NetworkMessage
    {
        public override ushort Id => 5925;
        
        
        public IEnumerable<ushort> cells;
        public IEnumerable<ushort> referenceIds;
        
        public ObjectGroundListAddedMessage()
        {
        }
        
        public ObjectGroundListAddedMessage(IEnumerable<ushort> cells, IEnumerable<ushort> referenceIds)
        {
            this.cells = cells;
            this.referenceIds = referenceIds;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)cells.Count());
            foreach (var entry in cells)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteShort((short)referenceIds.Count());
            foreach (var entry in referenceIds)
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
            limit = reader.ReadUShort();
            referenceIds = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (referenceIds as ushort[])[i] = reader.ReadVarUhShort();
            }
        }
        
    }
    
}