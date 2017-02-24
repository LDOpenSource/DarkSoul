

// Generated on 02/23/2017 18:06:43
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class TreasureHuntFlag
    {
        public virtual short TypeId => 473;
        
        public int mapId;
        public sbyte state;
        
        public TreasureHuntFlag()
        {
        }
        
        public TreasureHuntFlag(int mapId, sbyte state)
        {
            this.mapId = mapId;
            this.state = state;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteInt(mapId);
            writer.WriteSByte(state);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            mapId = reader.ReadInt();
            state = reader.ReadSByte();
        }
        
    }
    
}