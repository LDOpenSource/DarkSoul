

// Generated on 02/23/2017 18:06:39
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class FightStartingPositions
    {
        public virtual short TypeId => 513;
        
        public IEnumerable<ushort> positionsForChallengers;
        public IEnumerable<ushort> positionsForDefenders;
        
        public FightStartingPositions()
        {
        }
        
        public FightStartingPositions(IEnumerable<ushort> positionsForChallengers, IEnumerable<ushort> positionsForDefenders)
        {
            this.positionsForChallengers = positionsForChallengers;
            this.positionsForDefenders = positionsForDefenders;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteShort((short)positionsForChallengers.Count());
            foreach (var entry in positionsForChallengers)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteShort((short)positionsForDefenders.Count());
            foreach (var entry in positionsForDefenders)
            {
                 writer.WriteVarShort((int)entry);
            }
        }
        
        public virtual void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            positionsForChallengers = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (positionsForChallengers as ushort[])[i] = reader.ReadVarUhShort();
            }
            limit = reader.ReadUShort();
            positionsForDefenders = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (positionsForDefenders as ushort[])[i] = reader.ReadVarUhShort();
            }
        }
        
    }
    
}