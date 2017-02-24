

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
    public class GameMapNoMovementMessage : NetworkMessage
    {
        public override ushort Id => 954;
        
        
        public short cellX;
        public short cellY;
        
        public GameMapNoMovementMessage()
        {
        }
        
        public GameMapNoMovementMessage(short cellX, short cellY)
        {
            this.cellX = cellX;
            this.cellY = cellY;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort(cellX);
            writer.WriteShort(cellY);
        }
        
        public override void Deserialize(IReader reader)
        {
            cellX = reader.ReadShort();
            cellY = reader.ReadShort();
        }
        
    }
    
}