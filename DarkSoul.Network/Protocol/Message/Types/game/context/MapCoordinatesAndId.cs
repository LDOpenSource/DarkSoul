

// Generated on 02/23/2017 18:06:39
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class MapCoordinatesAndId : MapCoordinates
    {
        public override short TypeId => 392;
        
        public int mapId;
        
        public MapCoordinatesAndId()
        {
        }
        
        public MapCoordinatesAndId(short worldX, short worldY, int mapId)
         : base(worldX, worldY)
        {
            this.mapId = mapId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteInt(mapId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            mapId = reader.ReadInt();
        }
        
    }
    
}