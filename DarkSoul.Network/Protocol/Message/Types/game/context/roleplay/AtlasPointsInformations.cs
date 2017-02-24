

// Generated on 02/23/2017 18:06:41
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class AtlasPointsInformations
    {
        public virtual short TypeId => 175;
        
        public sbyte type;
        public IEnumerable<Types.MapCoordinatesExtended> coords;
        
        public AtlasPointsInformations()
        {
        }
        
        public AtlasPointsInformations(sbyte type, IEnumerable<Types.MapCoordinatesExtended> coords)
        {
            this.type = type;
            this.coords = coords;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteSByte(type);
            writer.WriteShort((short)coords.Count());
            foreach (var entry in coords)
            {
                 entry.Serialize(writer);
            }
        }
        
        public virtual void Deserialize(IReader reader)
        {
            type = reader.ReadSByte();
            var limit = reader.ReadUShort();
            coords = new Types.MapCoordinatesExtended[limit];
            for (int i = 0; i < limit; i++)
            {
                 (coords as Types.MapCoordinatesExtended[])[i] = new Types.MapCoordinatesExtended();
                 (coords as Types.MapCoordinatesExtended[])[i].Deserialize(reader);
            }
        }
        
    }
    
}