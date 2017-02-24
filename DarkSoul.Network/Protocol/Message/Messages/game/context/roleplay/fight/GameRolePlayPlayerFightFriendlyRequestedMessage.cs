

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
    public class GameRolePlayPlayerFightFriendlyRequestedMessage : NetworkMessage
    {
        public override ushort Id => 5937;
        
        
        public int fightId;
        public double sourceId;
        public double targetId;
        
        public GameRolePlayPlayerFightFriendlyRequestedMessage()
        {
        }
        
        public GameRolePlayPlayerFightFriendlyRequestedMessage(int fightId, double sourceId, double targetId)
        {
            this.fightId = fightId;
            this.sourceId = sourceId;
            this.targetId = targetId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteInt(fightId);
            writer.WriteVarLong(sourceId);
            writer.WriteVarLong(targetId);
        }
        
        public override void Deserialize(IReader reader)
        {
            fightId = reader.ReadInt();
            sourceId = reader.ReadVarUhLong();
            targetId = reader.ReadVarUhLong();
        }
        
    }
    
}