

// Generated on 02/23/2017 16:53:19
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameActionFightReduceDamagesMessage : AbstractGameActionMessage
    {
        public override ushort Id => 5526;
        
        
        public double targetId;
        public uint amount;
        
        public GameActionFightReduceDamagesMessage()
        {
        }
        
        public GameActionFightReduceDamagesMessage(ushort actionId, double sourceId, double targetId, uint amount)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.amount = amount;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(targetId);
            writer.WriteVarInt((int)amount);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            targetId = reader.ReadDouble();
            amount = reader.ReadVarUhInt();
        }
        
    }
    
}