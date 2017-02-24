

// Generated on 02/23/2017 16:53:20
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameActionFightStealKamaMessage : AbstractGameActionMessage
    {
        public override ushort Id => 5535;
        
        
        public double targetId;
        public double amount;
        
        public GameActionFightStealKamaMessage()
        {
        }
        
        public GameActionFightStealKamaMessage(ushort actionId, double sourceId, double targetId, double amount)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.amount = amount;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(targetId);
            writer.WriteVarLong(amount);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            targetId = reader.ReadDouble();
            amount = reader.ReadVarUhLong();
        }
        
    }
    
}