

// Generated on 02/23/2017 18:06:45
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class InteractiveElementNamedSkill : InteractiveElementSkill
    {
        public override short TypeId => 220;
        
        public uint nameId;
        
        public InteractiveElementNamedSkill()
        {
        }
        
        public InteractiveElementNamedSkill(uint skillId, int skillInstanceUid, uint nameId)
         : base(skillId, skillInstanceUid)
        {
            this.nameId = nameId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt((int)nameId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            nameId = reader.ReadVarUhInt();
        }
        
    }
    
}