

// Generated on 02/23/2017 18:06:39
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class MapCoordinates
    {
        public virtual short TypeId => 174;
        
        public short worldX;
        public short worldY;
        
        public MapCoordinates()
        {
        }
        
        public MapCoordinates(short worldX, short worldY)
        {
            this.worldX = worldX;
            this.worldY = worldY;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            worldX = reader.ReadShort();
            worldY = reader.ReadShort();
        }
        
    }
    
}