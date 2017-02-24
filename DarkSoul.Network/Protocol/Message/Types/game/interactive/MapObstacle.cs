

// Generated on 02/23/2017 18:06:45
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class MapObstacle
    {
        public virtual short TypeId => 200;
        
        public ushort obstacleCellId;
        public sbyte state;
        
        public MapObstacle()
        {
        }
        
        public MapObstacle(ushort obstacleCellId, sbyte state)
        {
            this.obstacleCellId = obstacleCellId;
            this.state = state;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)obstacleCellId);
            writer.WriteSByte(state);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            obstacleCellId = reader.ReadVarUhShort();
            state = reader.ReadSByte();
        }
        
    }
    
}