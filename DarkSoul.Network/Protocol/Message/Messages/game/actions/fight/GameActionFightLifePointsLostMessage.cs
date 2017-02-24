

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
    public class GameActionFightLifePointsLostMessage : AbstractGameActionMessage
    {
        public override ushort Id => 6312;
        
        
        public double targetId;
        public uint loss;
        public uint permanentDamages;
        
        public GameActionFightLifePointsLostMessage()
        {
        }
        
        public GameActionFightLifePointsLostMessage(ushort actionId, double sourceId, double targetId, uint loss, uint permanentDamages)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.loss = loss;
            this.permanentDamages = permanentDamages;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(targetId);
            writer.WriteVarInt((int)loss);
            writer.WriteVarInt((int)permanentDamages);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            targetId = reader.ReadDouble();
            loss = reader.ReadVarUhInt();
            permanentDamages = reader.ReadVarUhInt();
        }
        
    }
    
}