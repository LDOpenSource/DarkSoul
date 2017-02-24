

// Generated on 02/23/2017 18:06:44
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class ObjectEffect
    {
        public virtual short TypeId => 76;
        
        public ushort actionId;
        
        public ObjectEffect()
        {
        }
        
        public ObjectEffect(ushort actionId)
        {
            this.actionId = actionId;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)actionId);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            actionId = reader.ReadVarUhShort();
        }
        
    }
    
}