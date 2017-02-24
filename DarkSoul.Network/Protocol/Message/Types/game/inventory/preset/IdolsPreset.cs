

// Generated on 02/23/2017 18:06:46
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class IdolsPreset
    {
        public virtual short TypeId => 491;
        
        public sbyte presetId;
        public sbyte symbolId;
        public IEnumerable<ushort> idolId;
        
        public IdolsPreset()
        {
        }
        
        public IdolsPreset(sbyte presetId, sbyte symbolId, IEnumerable<ushort> idolId)
        {
            this.presetId = presetId;
            this.symbolId = symbolId;
            this.idolId = idolId;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteSByte(presetId);
            writer.WriteSByte(symbolId);
            writer.WriteShort((short)idolId.Count());
            foreach (var entry in idolId)
            {
                 writer.WriteVarShort((int)entry);
            }
        }
        
        public virtual void Deserialize(IReader reader)
        {
            presetId = reader.ReadSByte();
            symbolId = reader.ReadSByte();
            var limit = reader.ReadUShort();
            idolId = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (idolId as ushort[])[i] = reader.ReadVarUhShort();
            }
        }
        
    }
    
}