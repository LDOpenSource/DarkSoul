

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
    public class AchievementRewardRequestMessage : NetworkMessage
    {
        public override ushort Id => 6377;
        
        
        public short achievementId;
        
        public AchievementRewardRequestMessage()
        {
        }
        
        public AchievementRewardRequestMessage(short achievementId)
        {
            this.achievementId = achievementId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort(achievementId);
        }
        
        public override void Deserialize(IReader reader)
        {
            achievementId = reader.ReadShort();
        }
        
    }
    
}