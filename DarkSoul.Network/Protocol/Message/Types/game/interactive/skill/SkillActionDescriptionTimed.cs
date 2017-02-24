

// Generated on 02/23/2017 18:06:45
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class SkillActionDescriptionTimed : SkillActionDescription
    {
        public override short TypeId => 103;
        
        public byte time;
        
        public SkillActionDescriptionTimed()
        {
        }
        
        public SkillActionDescriptionTimed(ushort skillId, byte time)
         : base(skillId)
        {
            this.time = time;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteByte(time);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            time = reader.ReadByte();
        }
        
    }
    
}