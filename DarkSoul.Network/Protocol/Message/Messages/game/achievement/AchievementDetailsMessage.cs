

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
    public class AchievementDetailsMessage : NetworkMessage
    {
        public override ushort Id => 6378;
        
        
        public Types.Achievement achievement;
        
        public AchievementDetailsMessage()
        {
        }
        
        public AchievementDetailsMessage(Types.Achievement achievement)
        {
            this.achievement = achievement;
        }
        
        public override void Serialize(IWriter writer)
        {
            achievement.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            achievement = new Types.Achievement();
            achievement.Deserialize(reader);
        }
        
    }
    
}