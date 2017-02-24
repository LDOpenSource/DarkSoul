

// Generated on 02/23/2017 18:06:37
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class Achievement
    {
        public virtual short TypeId => 363;
        
        public ushort id;
        public IEnumerable<Types.AchievementObjective> finishedObjective;
        public IEnumerable<Types.AchievementStartedObjective> startedObjectives;
        
        public Achievement()
        {
        }
        
        public Achievement(ushort id, IEnumerable<Types.AchievementObjective> finishedObjective, IEnumerable<Types.AchievementStartedObjective> startedObjectives)
        {
            this.id = id;
            this.finishedObjective = finishedObjective;
            this.startedObjectives = startedObjectives;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)id);
            writer.WriteShort((short)finishedObjective.Count());
            foreach (var entry in finishedObjective)
            {
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)startedObjectives.Count());
            foreach (var entry in startedObjectives)
            {
                 entry.Serialize(writer);
            }
        }
        
        public virtual void Deserialize(IReader reader)
        {
            id = reader.ReadVarUhShort();
            var limit = reader.ReadUShort();
            finishedObjective = new Types.AchievementObjective[limit];
            for (int i = 0; i < limit; i++)
            {
                 (finishedObjective as Types.AchievementObjective[])[i] = new Types.AchievementObjective();
                 (finishedObjective as Types.AchievementObjective[])[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            startedObjectives = new Types.AchievementStartedObjective[limit];
            for (int i = 0; i < limit; i++)
            {
                 (startedObjectives as Types.AchievementStartedObjective[])[i] = new Types.AchievementStartedObjective();
                 (startedObjectives as Types.AchievementStartedObjective[])[i].Deserialize(reader);
            }
        }
        
    }
    
}