

// Generated on 02/23/2017 16:53:36
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameRolePlayArenaRegisterMessage : NetworkMessage
    {
        public override ushort Id => 6280;
        
        
        public int battleMode;
        
        public GameRolePlayArenaRegisterMessage()
        {
        }
        
        public GameRolePlayArenaRegisterMessage(int battleMode)
        {
            this.battleMode = battleMode;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteInt(battleMode);
        }
        
        public override void Deserialize(IReader reader)
        {
            battleMode = reader.ReadInt();
        }
        
    }
    
}