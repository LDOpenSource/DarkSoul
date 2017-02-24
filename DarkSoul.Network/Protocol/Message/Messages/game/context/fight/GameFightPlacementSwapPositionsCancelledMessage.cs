

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
    public class GameFightPlacementSwapPositionsCancelledMessage : NetworkMessage
    {
        public override ushort Id => 6546;
        
        
        public int requestId;
        public double cancellerId;
        
        public GameFightPlacementSwapPositionsCancelledMessage()
        {
        }
        
        public GameFightPlacementSwapPositionsCancelledMessage(int requestId, double cancellerId)
        {
            this.requestId = requestId;
            this.cancellerId = cancellerId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteInt(requestId);
            writer.WriteDouble(cancellerId);
        }
        
        public override void Deserialize(IReader reader)
        {
            requestId = reader.ReadInt();
            cancellerId = reader.ReadDouble();
        }
        
    }
    
}