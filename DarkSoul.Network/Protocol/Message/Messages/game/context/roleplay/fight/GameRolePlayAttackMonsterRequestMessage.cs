

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
    public class GameRolePlayAttackMonsterRequestMessage : NetworkMessage
    {
        public override ushort Id => 6191;
        
        
        public double monsterGroupId;
        
        public GameRolePlayAttackMonsterRequestMessage()
        {
        }
        
        public GameRolePlayAttackMonsterRequestMessage(double monsterGroupId)
        {
            this.monsterGroupId = monsterGroupId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteDouble(monsterGroupId);
        }
        
        public override void Deserialize(IReader reader)
        {
            monsterGroupId = reader.ReadDouble();
        }
        
    }
    
}