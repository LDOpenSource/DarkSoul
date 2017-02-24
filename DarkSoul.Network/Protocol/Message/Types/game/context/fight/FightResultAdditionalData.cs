

// Generated on 02/23/2017 18:06:39
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class FightResultAdditionalData
    {
        public virtual short TypeId => 191;
        
        
        public FightResultAdditionalData()
        {
        }
        
        
        public virtual void Serialize(IWriter writer)
        {
        }
        
        public virtual void Deserialize(IReader reader)
        {
        }
        
    }
    
}