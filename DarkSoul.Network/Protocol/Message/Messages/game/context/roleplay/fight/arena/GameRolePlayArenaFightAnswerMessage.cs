

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
    public class GameRolePlayArenaFightAnswerMessage : NetworkMessage
    {
        public override ushort Id => 6279;
        
        
        public int fightId;
        public bool accept;
        
        public GameRolePlayArenaFightAnswerMessage()
        {
        }
        
        public GameRolePlayArenaFightAnswerMessage(int fightId, bool accept)
        {
            this.fightId = fightId;
            this.accept = accept;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteInt(fightId);
            writer.WriteBoolean(accept);
        }
        
        public override void Deserialize(IReader reader)
        {
            fightId = reader.ReadInt();
            accept = reader.ReadBoolean();
        }
        
    }
    
}