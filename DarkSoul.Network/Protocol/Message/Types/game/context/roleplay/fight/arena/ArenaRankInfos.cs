

// Generated on 02/23/2017 18:06:42
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class ArenaRankInfos
    {
        public virtual short TypeId => 499;
        
        public ushort rank;
        public ushort bestRank;
        public ushort victoryCount;
        public ushort fightcount;
        
        public ArenaRankInfos()
        {
        }
        
        public ArenaRankInfos(ushort rank, ushort bestRank, ushort victoryCount, ushort fightcount)
        {
            this.rank = rank;
            this.bestRank = bestRank;
            this.victoryCount = victoryCount;
            this.fightcount = fightcount;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)rank);
            writer.WriteVarShort((int)bestRank);
            writer.WriteVarShort((int)victoryCount);
            writer.WriteVarShort((int)fightcount);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            rank = reader.ReadVarUhShort();
            bestRank = reader.ReadVarUhShort();
            victoryCount = reader.ReadVarUhShort();
            fightcount = reader.ReadVarUhShort();
        }
        
    }
    
}