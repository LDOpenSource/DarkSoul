

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
    public class GameMapChangeOrientationRequestMessage : NetworkMessage
    {
        public override ushort Id => 945;
        
        
        public sbyte direction;
        
        public GameMapChangeOrientationRequestMessage()
        {
        }
        
        public GameMapChangeOrientationRequestMessage(sbyte direction)
        {
            this.direction = direction;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(direction);
        }
        
        public override void Deserialize(IReader reader)
        {
            direction = reader.ReadSByte();
        }
        
    }
    
}