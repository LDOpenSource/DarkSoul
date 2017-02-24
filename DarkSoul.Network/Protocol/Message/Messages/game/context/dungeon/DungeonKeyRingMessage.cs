

// Generated on 02/23/2017 16:53:29
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class DungeonKeyRingMessage : NetworkMessage
    {
        public override ushort Id => 6299;
        
        
        public IEnumerable<ushort> availables;
        public IEnumerable<ushort> unavailables;
        
        public DungeonKeyRingMessage()
        {
        }
        
        public DungeonKeyRingMessage(IEnumerable<ushort> availables, IEnumerable<ushort> unavailables)
        {
            this.availables = availables;
            this.unavailables = unavailables;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)availables.Count());
            foreach (var entry in availables)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteShort((short)unavailables.Count());
            foreach (var entry in unavailables)
            {
                 writer.WriteVarShort((int)entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            availables = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (availables as ushort[])[i] = reader.ReadVarUhShort();
            }
            limit = reader.ReadUShort();
            unavailables = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (unavailables as ushort[])[i] = reader.ReadVarUhShort();
            }
        }
        
    }
    
}