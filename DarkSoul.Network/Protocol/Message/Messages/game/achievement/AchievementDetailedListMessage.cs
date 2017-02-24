

// Generated on 02/23/2017 16:53:17
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class AchievementDetailedListMessage : NetworkMessage
    {
        public override ushort Id => 6358;
        
        
        public IEnumerable<Types.Achievement> startedAchievements;
        public IEnumerable<Types.Achievement> finishedAchievements;
        
        public AchievementDetailedListMessage()
        {
        }
        
        public AchievementDetailedListMessage(IEnumerable<Types.Achievement> startedAchievements, IEnumerable<Types.Achievement> finishedAchievements)
        {
            this.startedAchievements = startedAchievements;
            this.finishedAchievements = finishedAchievements;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)startedAchievements.Count());
            foreach (var entry in startedAchievements)
            {
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)finishedAchievements.Count());
            foreach (var entry in finishedAchievements)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            startedAchievements = new Types.Achievement[limit];
            for (int i = 0; i < limit; i++)
            {
                 (startedAchievements as Types.Achievement[])[i] = new Types.Achievement();
                 (startedAchievements as Types.Achievement[])[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            finishedAchievements = new Types.Achievement[limit];
            for (int i = 0; i < limit; i++)
            {
                 (finishedAchievements as Types.Achievement[])[i] = new Types.Achievement();
                 (finishedAchievements as Types.Achievement[])[i].Deserialize(reader);
            }
        }
        
    }
    
}