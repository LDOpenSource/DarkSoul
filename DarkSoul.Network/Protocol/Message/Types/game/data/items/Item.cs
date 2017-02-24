

// Generated on 02/23/2017 18:06:43
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class Item
    {
        public virtual short TypeId => 7;
        
        
        public Item()
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