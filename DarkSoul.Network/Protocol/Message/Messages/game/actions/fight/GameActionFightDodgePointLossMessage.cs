

// Generated on 02/23/2017 16:53:18
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameActionFightDodgePointLossMessage : AbstractGameActionMessage
    {
        public override ushort Id => 5828;
        
        
        public double targetId;
        public ushort amount;
        
        public GameActionFightDodgePointLossMessage()
        {
        }
        
        public GameActionFightDodgePointLossMessage(ushort actionId, double sourceId, double targetId, ushort amount)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.amount = amount;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(targetId);
            writer.WriteVarShort((int)amount);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            targetId = reader.ReadDouble();
            amount = reader.ReadVarUhShort();
        }
        
    }
    
}