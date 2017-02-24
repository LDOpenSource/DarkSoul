

// Generated on 02/23/2017 16:53:29
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameMapChangeOrientationMessage : NetworkMessage
    {
        public override ushort Id => 946;
        
        
        public Types.ActorOrientation orientation;
        
        public GameMapChangeOrientationMessage()
        {
        }
        
        public GameMapChangeOrientationMessage(Types.ActorOrientation orientation)
        {
            this.orientation = orientation;
        }
        
        public override void Serialize(IWriter writer)
        {
            orientation.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            orientation = new Types.ActorOrientation();
            orientation.Deserialize(reader);
        }
        
    }
    
}