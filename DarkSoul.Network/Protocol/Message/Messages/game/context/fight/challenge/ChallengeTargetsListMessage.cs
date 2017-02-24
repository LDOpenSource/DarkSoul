

// Generated on 02/23/2017 16:53:31
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ChallengeTargetsListMessage : NetworkMessage
    {
        public override ushort Id => 5613;
        
        
        public IEnumerable<double> targetIds;
        public IEnumerable<short> targetCells;
        
        public ChallengeTargetsListMessage()
        {
        }
        
        public ChallengeTargetsListMessage(IEnumerable<double> targetIds, IEnumerable<short> targetCells)
        {
            this.targetIds = targetIds;
            this.targetCells = targetCells;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)targetIds.Count());
            foreach (var entry in targetIds)
            {
                 writer.WriteDouble(entry);
            }
            writer.WriteShort((short)targetCells.Count());
            foreach (var entry in targetCells)
            {
                 writer.WriteShort(entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            targetIds = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 (targetIds as double[])[i] = reader.ReadDouble();
            }
            limit = reader.ReadUShort();
            targetCells = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 (targetCells as short[])[i] = reader.ReadShort();
            }
        }
        
    }
    
}