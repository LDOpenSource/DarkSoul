

// Generated on 02/23/2017 16:53:45
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class TreasureHuntShowLegendaryUIMessage : NetworkMessage
    {
        public override ushort Id => 6498;
        
        
        public IEnumerable<ushort> availableLegendaryIds;
        
        public TreasureHuntShowLegendaryUIMessage()
        {
        }
        
        public TreasureHuntShowLegendaryUIMessage(IEnumerable<ushort> availableLegendaryIds)
        {
            this.availableLegendaryIds = availableLegendaryIds;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)availableLegendaryIds.Count());
            foreach (var entry in availableLegendaryIds)
            {
                 writer.WriteVarShort((int)entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            availableLegendaryIds = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (availableLegendaryIds as ushort[])[i] = reader.ReadVarUhShort();
            }
        }
        
    }
    
}