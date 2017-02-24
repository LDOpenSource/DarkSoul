

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
    public class GameFightPlacementSwapPositionsRequestMessage : GameFightPlacementPositionRequestMessage
    {
        public override ushort Id => 6541;
        
        
        public double requestedId;
        
        public GameFightPlacementSwapPositionsRequestMessage()
        {
        }
        
        public GameFightPlacementSwapPositionsRequestMessage(ushort cellId, double requestedId)
         : base(cellId)
        {
            this.requestedId = requestedId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(requestedId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            requestedId = reader.ReadDouble();
        }
        
    }
    
}