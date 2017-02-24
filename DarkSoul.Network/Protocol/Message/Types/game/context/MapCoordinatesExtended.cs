

// Generated on 02/23/2017 18:06:39
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class MapCoordinatesExtended : MapCoordinatesAndId
    {
        public override short TypeId => 176;
        
        public ushort subAreaId;
        
        public MapCoordinatesExtended()
        {
        }
        
        public MapCoordinatesExtended(short worldX, short worldY, int mapId, ushort subAreaId)
         : base(worldX, worldY, mapId)
        {
            this.subAreaId = subAreaId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((int)subAreaId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            subAreaId = reader.ReadVarUhShort();
        }
        
    }
    
}