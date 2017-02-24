

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
    public class GameCautiousMapMovementRequestMessage : GameMapMovementRequestMessage
    {
        public override ushort Id => 6496;
        
        
        
        public GameCautiousMapMovementRequestMessage()
        {
        }
        
        public GameCautiousMapMovementRequestMessage(IEnumerable<short> keyMovements, int mapId)
         : base(keyMovements, mapId)
        {
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
        }
        
    }
    
}