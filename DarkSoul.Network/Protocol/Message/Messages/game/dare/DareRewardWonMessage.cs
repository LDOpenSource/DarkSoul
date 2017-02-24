

// Generated on 02/23/2017 16:53:45
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class DareRewardWonMessage : NetworkMessage
    {
        public override ushort Id => 6678;
        
        
        public Types.DareReward reward;
        
        public DareRewardWonMessage()
        {
        }
        
        public DareRewardWonMessage(Types.DareReward reward)
        {
            this.reward = reward;
        }
        
        public override void Serialize(IWriter writer)
        {
            reward.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            reward = new Types.DareReward();
            reward.Deserialize(reader);
        }
        
    }
    
}