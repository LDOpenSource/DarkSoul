

// Generated on 02/23/2017 18:06:45
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class SkillActionDescriptionCraft : SkillActionDescription
    {
        public override short TypeId => 100;
        
        public sbyte probability;
        
        public SkillActionDescriptionCraft()
        {
        }
        
        public SkillActionDescriptionCraft(ushort skillId, sbyte probability)
         : base(skillId)
        {
            this.probability = probability;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSByte(probability);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            probability = reader.ReadSByte();
        }
        
    }
    
}