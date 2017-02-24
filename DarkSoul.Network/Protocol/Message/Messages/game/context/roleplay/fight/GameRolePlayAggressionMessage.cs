

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
    public class GameRolePlayAggressionMessage : NetworkMessage
    {
        public override ushort Id => 6073;
        
        
        public double attackerId;
        public double defenderId;
        
        public GameRolePlayAggressionMessage()
        {
        }
        
        public GameRolePlayAggressionMessage(double attackerId, double defenderId)
        {
            this.attackerId = attackerId;
            this.defenderId = defenderId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarLong(attackerId);
            writer.WriteVarLong(defenderId);
        }
        
        public override void Deserialize(IReader reader)
        {
            attackerId = reader.ReadVarUhLong();
            defenderId = reader.ReadVarUhLong();
        }
        
    }
    
}