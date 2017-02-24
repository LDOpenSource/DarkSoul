

// Generated on 02/23/2017 16:53:27
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameCautiousMapMovementMessage : GameMapMovementMessage
    {
        public override ushort Id => 6497;
        
        
        
        public GameCautiousMapMovementMessage()
        {
        }
        
        public GameCautiousMapMovementMessage(IEnumerable<short> keyMovements, short forcedDirection, double actorId)
         : base(keyMovements, forcedDirection, actorId)
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