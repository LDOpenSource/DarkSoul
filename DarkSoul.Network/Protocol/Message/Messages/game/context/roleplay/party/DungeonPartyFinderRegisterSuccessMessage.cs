

// Generated on 02/23/2017 16:53:40
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class DungeonPartyFinderRegisterSuccessMessage : NetworkMessage
    {
        public override ushort Id => 6241;
        
        
        public IEnumerable<ushort> dungeonIds;
        
        public DungeonPartyFinderRegisterSuccessMessage()
        {
        }
        
        public DungeonPartyFinderRegisterSuccessMessage(IEnumerable<ushort> dungeonIds)
        {
            this.dungeonIds = dungeonIds;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)dungeonIds.Count());
            foreach (var entry in dungeonIds)
            {
                 writer.WriteVarShort((int)entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            dungeonIds = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (dungeonIds as ushort[])[i] = reader.ReadVarUhShort();
            }
        }
        
    }
    
}