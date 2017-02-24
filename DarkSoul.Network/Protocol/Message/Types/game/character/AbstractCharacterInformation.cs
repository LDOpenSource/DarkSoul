

// Generated on 02/23/2017 18:06:37
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class AbstractCharacterInformation
    {
        public virtual short TypeId => 400;
        
        public double id;
        
        public AbstractCharacterInformation()
        {
        }
        
        public AbstractCharacterInformation(double id)
        {
            this.id = id;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteVarLong(id);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            id = reader.ReadVarUhLong();
        }
        
    }
    
}