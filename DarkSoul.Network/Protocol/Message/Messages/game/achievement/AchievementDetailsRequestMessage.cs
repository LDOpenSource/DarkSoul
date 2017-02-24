

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
    public class AchievementDetailsRequestMessage : NetworkMessage
    {
        public override ushort Id => 6380;
        
        
        public ushort achievementId;
        
        public AchievementDetailsRequestMessage()
        {
        }
        
        public AchievementDetailsRequestMessage(ushort achievementId)
        {
            this.achievementId = achievementId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)achievementId);
        }
        
        public override void Deserialize(IReader reader)
        {
            achievementId = reader.ReadVarUhShort();
        }
        
    }
    
}