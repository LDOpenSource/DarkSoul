

// Generated on 02/23/2017 18:06:45
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class InteractiveElementSkill
    {
        public virtual short TypeId => 219;
        
        public uint skillId;
        public int skillInstanceUid;
        
        public InteractiveElementSkill()
        {
        }
        
        public InteractiveElementSkill(uint skillId, int skillInstanceUid)
        {
            this.skillId = skillId;
            this.skillInstanceUid = skillInstanceUid;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)skillId);
            writer.WriteInt(skillInstanceUid);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            skillId = reader.ReadVarUhInt();
            skillInstanceUid = reader.ReadInt();
        }
        
    }
    
}