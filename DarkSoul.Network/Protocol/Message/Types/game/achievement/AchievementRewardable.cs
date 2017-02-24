

// Generated on 02/23/2017 18:06:37
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class AchievementRewardable
    {
        public virtual short TypeId => 412;
        
        public ushort id;
        public byte finishedlevel;
        
        public AchievementRewardable()
        {
        }
        
        public AchievementRewardable(ushort id, byte finishedlevel)
        {
            this.id = id;
            this.finishedlevel = finishedlevel;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)id);
            writer.WriteByte(finishedlevel);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            id = reader.ReadVarUhShort();
            finishedlevel = reader.ReadByte();
        }
        
    }
    
}