

// Generated on 02/23/2017 18:06:43
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class DareVersatileInformations
    {
        public virtual short TypeId => 504;
        
        public double dareId;
        public int countEntrants;
        public int countWinners;
        
        public DareVersatileInformations()
        {
        }
        
        public DareVersatileInformations(double dareId, int countEntrants, int countWinners)
        {
            this.dareId = dareId;
            this.countEntrants = countEntrants;
            this.countWinners = countWinners;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteDouble(dareId);
            writer.WriteInt(countEntrants);
            writer.WriteInt(countWinners);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            dareId = reader.ReadDouble();
            countEntrants = reader.ReadInt();
            countWinners = reader.ReadInt();
        }
        
    }
    
}