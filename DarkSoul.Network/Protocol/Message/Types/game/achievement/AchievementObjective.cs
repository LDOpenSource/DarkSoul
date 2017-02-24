

// Generated on 02/23/2017 18:06:37
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class AchievementObjective
    {
        public virtual short TypeId => 404;
        
        public uint id;
        public ushort maxValue;
        
        public AchievementObjective()
        {
        }
        
        public AchievementObjective(uint id, ushort maxValue)
        {
            this.id = id;
            this.maxValue = maxValue;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)id);
            writer.WriteVarShort((int)maxValue);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            id = reader.ReadVarUhInt();
            maxValue = reader.ReadVarUhShort();
        }
        
    }
    
}