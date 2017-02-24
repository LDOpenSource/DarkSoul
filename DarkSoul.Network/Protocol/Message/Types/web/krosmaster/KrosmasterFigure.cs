

// Generated on 02/23/2017 18:06:47
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class KrosmasterFigure
    {
        public virtual short TypeId => 397;
        
        public string uid;
        public ushort figure;
        public ushort pedestal;
        public bool bound;
        
        public KrosmasterFigure()
        {
        }
        
        public KrosmasterFigure(string uid, ushort figure, ushort pedestal, bool bound)
        {
            this.uid = uid;
            this.figure = figure;
            this.pedestal = pedestal;
            this.bound = bound;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteUTF(uid);
            writer.WriteVarShort((int)figure);
            writer.WriteVarShort((int)pedestal);
            writer.WriteBoolean(bound);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            uid = reader.ReadUTF();
            figure = reader.ReadVarUhShort();
            pedestal = reader.ReadVarUhShort();
            bound = reader.ReadBoolean();
        }
        
    }
    
}