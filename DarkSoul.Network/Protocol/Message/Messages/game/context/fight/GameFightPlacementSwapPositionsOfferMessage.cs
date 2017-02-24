

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
    public class GameFightPlacementSwapPositionsOfferMessage : NetworkMessage
    {
        public override ushort Id => 6542;
        
        
        public int requestId;
        public double requesterId;
        public ushort requesterCellId;
        public double requestedId;
        public ushort requestedCellId;
        
        public GameFightPlacementSwapPositionsOfferMessage()
        {
        }
        
        public GameFightPlacementSwapPositionsOfferMessage(int requestId, double requesterId, ushort requesterCellId, double requestedId, ushort requestedCellId)
        {
            this.requestId = requestId;
            this.requesterId = requesterId;
            this.requesterCellId = requesterCellId;
            this.requestedId = requestedId;
            this.requestedCellId = requestedCellId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteInt(requestId);
            writer.WriteDouble(requesterId);
            writer.WriteVarShort((int)requesterCellId);
            writer.WriteDouble(requestedId);
            writer.WriteVarShort((int)requestedCellId);
        }
        
        public override void Deserialize(IReader reader)
        {
            requestId = reader.ReadInt();
            requesterId = reader.ReadDouble();
            requesterCellId = reader.ReadVarUhShort();
            requestedId = reader.ReadDouble();
            requestedCellId = reader.ReadVarUhShort();
        }
        
    }
    
}