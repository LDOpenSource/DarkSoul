

// Generated on 02/23/2017 18:06:38
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class ActorOrientation
    {
        public virtual short TypeId => 353;
        
        public double id;
        public sbyte direction;
        
        public ActorOrientation()
        {
        }
        
        public ActorOrientation(double id, sbyte direction)
        {
            this.id = id;
            this.direction = direction;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteDouble(id);
            writer.WriteSByte(direction);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            id = reader.ReadDouble();
            direction = reader.ReadSByte();
        }
        
    }
    
}