

// Generated on 02/23/2017 18:06:42
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class HumanOptionSkillUse : HumanOption
    {
        public override short TypeId => 495;
        
        public uint elementId;
        public ushort skillId;
        public double skillEndTime;
        
        public HumanOptionSkillUse()
        {
        }
        
        public HumanOptionSkillUse(uint elementId, ushort skillId, double skillEndTime)
        {
            this.elementId = elementId;
            this.skillId = skillId;
            this.skillEndTime = skillEndTime;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt((int)elementId);
            writer.WriteVarShort((int)skillId);
            writer.WriteDouble(skillEndTime);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            elementId = reader.ReadVarUhInt();
            skillId = reader.ReadVarUhShort();
            skillEndTime = reader.ReadDouble();
        }
        
    }
    
}