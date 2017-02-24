

// Generated on 02/23/2017 18:06:44
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class FinishMoveInformations
    {
        public virtual short TypeId => 506;
        
        public int finishMoveId;
        public bool finishMoveState;
        
        public FinishMoveInformations()
        {
        }
        
        public FinishMoveInformations(int finishMoveId, bool finishMoveState)
        {
            this.finishMoveId = finishMoveId;
            this.finishMoveState = finishMoveState;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteInt(finishMoveId);
            writer.WriteBoolean(finishMoveState);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            finishMoveId = reader.ReadInt();
            finishMoveState = reader.ReadBoolean();
        }
        
    }
    
}