

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
    public class AchievementListMessage : NetworkMessage
    {
        public override ushort Id => 6205;
        
        
        public IEnumerable<ushort> finishedAchievementsIds;
        public IEnumerable<Types.AchievementRewardable> rewardableAchievements;
        
        public AchievementListMessage()
        {
        }
        
        public AchievementListMessage(IEnumerable<ushort> finishedAchievementsIds, IEnumerable<Types.AchievementRewardable> rewardableAchievements)
        {
            this.finishedAchievementsIds = finishedAchievementsIds;
            this.rewardableAchievements = rewardableAchievements;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)finishedAchievementsIds.Count());
            foreach (var entry in finishedAchievementsIds)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteShort((short)rewardableAchievements.Count());
            foreach (var entry in rewardableAchievements)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            finishedAchievementsIds = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (finishedAchievementsIds as ushort[])[i] = reader.ReadVarUhShort();
            }
            limit = reader.ReadUShort();
            rewardableAchievements = new Types.AchievementRewardable[limit];
            for (int i = 0; i < limit; i++)
            {
                 (rewardableAchievements as Types.AchievementRewardable[])[i] = new Types.AchievementRewardable();
                 (rewardableAchievements as Types.AchievementRewardable[])[i].Deserialize(reader);
            }
        }
        
    }
    
}