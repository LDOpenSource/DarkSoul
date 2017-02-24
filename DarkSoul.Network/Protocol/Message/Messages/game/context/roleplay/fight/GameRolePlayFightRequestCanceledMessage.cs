

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
    public class GameRolePlayFightRequestCanceledMessage : NetworkMessage
    {
        public override ushort Id => 5822;
        
        
        public int fightId;
        public double sourceId;
        public double targetId;
        
        public GameRolePlayFightRequestCanceledMessage()
        {
        }
        
        public GameRolePlayFightRequestCanceledMessage(int fightId, double sourceId, double targetId)
        {
            this.fightId = fightId;
            this.sourceId = sourceId;
            this.targetId = targetId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteInt(fightId);
            writer.WriteDouble(sourceId);
            writer.WriteDouble(targetId);
        }
        
        public override void Deserialize(IReader reader)
        {
            fightId = reader.ReadInt();
            sourceId = reader.ReadDouble();
            targetId = reader.ReadDouble();
        }
        
    }
    
}