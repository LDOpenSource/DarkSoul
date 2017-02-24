

// Generated on 02/23/2017 18:06:45
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class InteractiveElementWithAgeBonus : InteractiveElement
    {
        public override short TypeId => 398;
        
        public short ageBonus;
        
        public InteractiveElementWithAgeBonus()
        {
        }
        
        public InteractiveElementWithAgeBonus(int elementId, int elementTypeId, IEnumerable<Types.InteractiveElementSkill> enabledSkills, IEnumerable<Types.InteractiveElementSkill> disabledSkills, bool onCurrentMap, short ageBonus)
         : base(elementId, elementTypeId, enabledSkills, disabledSkills, onCurrentMap)
        {
            this.ageBonus = ageBonus;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(ageBonus);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            ageBonus = reader.ReadShort();
        }
        
    }
    
}