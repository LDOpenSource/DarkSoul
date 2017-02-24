

// Generated on 02/23/2017 18:06:39
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class IdentifiedEntityDispositionInformations : EntityDispositionInformations
    {
        public override short TypeId => 107;
        
        public double id;
        
        public IdentifiedEntityDispositionInformations()
        {
        }
        
        public IdentifiedEntityDispositionInformations(short cellId, sbyte direction, double id)
         : base(cellId, direction)
        {
            this.id = id;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(id);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            id = reader.ReadDouble();
        }
        
    }
    
}