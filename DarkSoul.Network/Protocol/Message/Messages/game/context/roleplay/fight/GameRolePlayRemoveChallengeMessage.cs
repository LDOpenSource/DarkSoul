

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
    public class GameRolePlayRemoveChallengeMessage : NetworkMessage
    {
        public override ushort Id => 300;
        
        
        public int fightId;
        
        public GameRolePlayRemoveChallengeMessage()
        {
        }
        
        public GameRolePlayRemoveChallengeMessage(int fightId)
        {
            this.fightId = fightId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteInt(fightId);
        }
        
        public override void Deserialize(IReader reader)
        {
            fightId = reader.ReadInt();
        }
        
    }
    
}