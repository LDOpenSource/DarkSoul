

// Generated on 02/23/2017 18:06:45
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class InteractiveElement
    {
        public virtual short TypeId => 80;
        
        public int elementId;
        public int elementTypeId;
        public IEnumerable<Types.InteractiveElementSkill> enabledSkills;
        public IEnumerable<Types.InteractiveElementSkill> disabledSkills;
        public bool onCurrentMap;
        
        public InteractiveElement()
        {
        }
        
        public InteractiveElement(int elementId, int elementTypeId, IEnumerable<Types.InteractiveElementSkill> enabledSkills, IEnumerable<Types.InteractiveElementSkill> disabledSkills, bool onCurrentMap)
        {
            this.elementId = elementId;
            this.elementTypeId = elementTypeId;
            this.enabledSkills = enabledSkills;
            this.disabledSkills = disabledSkills;
            this.onCurrentMap = onCurrentMap;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteInt(elementId);
            writer.WriteInt(elementTypeId);
            writer.WriteShort((short)enabledSkills.Count());
            foreach (var entry in enabledSkills)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)disabledSkills.Count());
            foreach (var entry in disabledSkills)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteBoolean(onCurrentMap);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            elementId = reader.ReadInt();
            elementTypeId = reader.ReadInt();
            var limit = reader.ReadUShort();
            enabledSkills = new Types.InteractiveElementSkill[limit];
            for (int i = 0; i < limit; i++)
            {
                 (enabledSkills as Types.InteractiveElementSkill[])[i] = ProtocolTypeManager.GetInstance<Types.InteractiveElementSkill>(reader.ReadUShort());
                 (enabledSkills as Types.InteractiveElementSkill[])[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            disabledSkills = new Types.InteractiveElementSkill[limit];
            for (int i = 0; i < limit; i++)
            {
                 (disabledSkills as Types.InteractiveElementSkill[])[i] = ProtocolTypeManager.GetInstance<Types.InteractiveElementSkill>(reader.ReadUShort());
                 (disabledSkills as Types.InteractiveElementSkill[])[i].Deserialize(reader);
            }
            onCurrentMap = reader.ReadBoolean();
        }
        
    }
    
}