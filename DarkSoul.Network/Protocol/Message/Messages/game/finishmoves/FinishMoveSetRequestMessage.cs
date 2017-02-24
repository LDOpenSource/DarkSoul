

// Generated on 02/23/2017 16:53:46
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class FinishMoveSetRequestMessage : NetworkMessage
    {
        public override ushort Id => 6703;
        
        
        public int finishMoveId;
        public bool finishMoveState;
        
        public FinishMoveSetRequestMessage()
        {
        }
        
        public FinishMoveSetRequestMessage(int finishMoveId, bool finishMoveState)
        {
            this.finishMoveId = finishMoveId;
            this.finishMoveState = finishMoveState;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteInt(finishMoveId);
            writer.WriteBoolean(finishMoveState);
        }
        
        public override void Deserialize(IReader reader)
        {
            finishMoveId = reader.ReadInt();
            finishMoveState = reader.ReadBoolean();
        }
        
    }
    
}