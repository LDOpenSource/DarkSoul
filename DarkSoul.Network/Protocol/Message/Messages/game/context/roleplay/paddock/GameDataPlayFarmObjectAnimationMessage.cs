

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
    public class GameDataPlayFarmObjectAnimationMessage : NetworkMessage
    {
        public override ushort Id => 6026;
        
        
        public IEnumerable<ushort> cellId;
        
        public GameDataPlayFarmObjectAnimationMessage()
        {
        }
        
        public GameDataPlayFarmObjectAnimationMessage(IEnumerable<ushort> cellId)
        {
            this.cellId = cellId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)cellId.Count());
            foreach (var entry in cellId)
            {
                 writer.WriteVarShort((int)entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            cellId = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (cellId as ushort[])[i] = reader.ReadVarUhShort();
            }
        }
        
    }
    
}