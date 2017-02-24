

// Generated on 02/23/2017 16:53:35
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameRolePlayShowChallengeMessage : NetworkMessage
    {
        public override ushort Id => 301;
        
        
        public Types.FightCommonInformations commonsInfos;
        
        public GameRolePlayShowChallengeMessage()
        {
        }
        
        public GameRolePlayShowChallengeMessage(Types.FightCommonInformations commonsInfos)
        {
            this.commonsInfos = commonsInfos;
        }
        
        public override void Serialize(IWriter writer)
        {
            commonsInfos.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            commonsInfos = new Types.FightCommonInformations();
            commonsInfos.Deserialize(reader);
        }
        
    }
    
}