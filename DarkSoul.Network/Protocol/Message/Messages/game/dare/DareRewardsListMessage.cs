

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
    public class DareRewardsListMessage : NetworkMessage
    {
        public override ushort Id => 6677;
        
        
        public IEnumerable<Types.DareReward> rewards;
        
        public DareRewardsListMessage()
        {
        }
        
        public DareRewardsListMessage(IEnumerable<Types.DareReward> rewards)
        {
            this.rewards = rewards;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)rewards.Count());
            foreach (var entry in rewards)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            rewards = new Types.DareReward[limit];
            for (int i = 0; i < limit; i++)
            {
                 (rewards as Types.DareReward[])[i] = new Types.DareReward();
                 (rewards as Types.DareReward[])[i].Deserialize(reader);
            }
        }
        
    }
    
}