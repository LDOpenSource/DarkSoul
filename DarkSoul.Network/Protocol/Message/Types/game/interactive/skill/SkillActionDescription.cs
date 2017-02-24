

// Generated on 02/23/2017 18:06:45
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class SkillActionDescription
    {
        public virtual short TypeId => 102;
        
        public ushort skillId;
        
        public SkillActionDescription()
        {
        }
        
        public SkillActionDescription(ushort skillId)
        {
            this.skillId = skillId;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)skillId);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            skillId = reader.ReadVarUhShort();
        }
        
    }
    
}