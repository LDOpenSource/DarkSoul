

// Generated on 02/23/2017 18:06:45
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class PartyIdol : Idol
    {
        public override short TypeId => 490;
        
        public IEnumerable<double> ownersIds;
        
        public PartyIdol()
        {
        }
        
        public PartyIdol(ushort id, ushort xpBonusPercent, ushort dropBonusPercent, IEnumerable<double> ownersIds)
         : base(id, xpBonusPercent, dropBonusPercent)
        {
            this.ownersIds = ownersIds;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort((short)ownersIds.Count());
            foreach (var entry in ownersIds)
            {
                 writer.WriteVarLong(entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            var limit = reader.ReadUShort();
            ownersIds = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 (ownersIds as double[])[i] = reader.ReadVarUhLong();
            }
        }
        
    }
    
}