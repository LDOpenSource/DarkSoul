

// Generated on 02/23/2017 18:06:46
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class PaddockInformations
    {
        public virtual short TypeId => 132;
        
        public ushort maxOutdoorMount;
        public ushort maxItems;
        
        public PaddockInformations()
        {
        }
        
        public PaddockInformations(ushort maxOutdoorMount, ushort maxItems)
        {
            this.maxOutdoorMount = maxOutdoorMount;
            this.maxItems = maxItems;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)maxOutdoorMount);
            writer.WriteVarShort((int)maxItems);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            maxOutdoorMount = reader.ReadVarUhShort();
            maxItems = reader.ReadVarUhShort();
        }
        
    }
    
}