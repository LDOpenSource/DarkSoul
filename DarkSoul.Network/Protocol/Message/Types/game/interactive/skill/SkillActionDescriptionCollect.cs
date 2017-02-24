

// Generated on 02/23/2017 18:06:45
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class SkillActionDescriptionCollect : SkillActionDescriptionTimed
    {
        public override short TypeId => 99;
        
        public ushort min;
        public ushort max;
        
        public SkillActionDescriptionCollect()
        {
        }
        
        public SkillActionDescriptionCollect(ushort skillId, byte time, ushort min, ushort max)
         : base(skillId, time)
        {
            this.min = min;
            this.max = max;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((int)min);
            writer.WriteVarShort((int)max);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            min = reader.ReadVarUhShort();
            max = reader.ReadVarUhShort();
        }
        
    }
    
}