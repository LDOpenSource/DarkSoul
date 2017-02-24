

// Generated on 02/23/2017 18:06:37
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class AchievementStartedObjective : AchievementObjective
    {
        public override short TypeId => 402;
        
        public ushort value;
        
        public AchievementStartedObjective()
        {
        }
        
        public AchievementStartedObjective(uint id, ushort maxValue, ushort value)
         : base(id, maxValue)
        {
            this.value = value;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((int)value);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            value = reader.ReadVarUhShort();
        }
        
    }
    
}