

// Generated on 02/23/2017 16:53:30
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameFightPlacementSwapPositionsAcceptMessage : NetworkMessage
    {
        public override ushort Id => 6547;
        
        
        public int requestId;
        
        public GameFightPlacementSwapPositionsAcceptMessage()
        {
        }
        
        public GameFightPlacementSwapPositionsAcceptMessage(int requestId)
        {
            this.requestId = requestId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteInt(requestId);
        }
        
        public override void Deserialize(IReader reader)
        {
            requestId = reader.ReadInt();
        }
        
    }
    
}