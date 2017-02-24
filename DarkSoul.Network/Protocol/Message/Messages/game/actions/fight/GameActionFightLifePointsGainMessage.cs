

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
    public class GameActionFightLifePointsGainMessage : AbstractGameActionMessage
    {
        public override ushort Id => 6311;
        
        
        public double targetId;
        public uint delta;
        
        public GameActionFightLifePointsGainMessage()
        {
        }
        
        public GameActionFightLifePointsGainMessage(ushort actionId, double sourceId, double targetId, uint delta)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.delta = delta;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(targetId);
            writer.WriteVarInt((int)delta);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            targetId = reader.ReadDouble();
            delta = reader.ReadVarUhInt();
        }
        
    }
    
}