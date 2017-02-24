

// Generated on 02/23/2017 16:53:28
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameContextMoveElementMessage : NetworkMessage
    {
        public override ushort Id => 253;
        
        
        public Types.EntityMovementInformations movement;
        
        public GameContextMoveElementMessage()
        {
        }
        
        public GameContextMoveElementMessage(Types.EntityMovementInformations movement)
        {
            this.movement = movement;
        }
        
        public override void Serialize(IWriter writer)
        {
            movement.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            movement = new Types.EntityMovementInformations();
            movement.Deserialize(reader);
        }
        
    }
    
}