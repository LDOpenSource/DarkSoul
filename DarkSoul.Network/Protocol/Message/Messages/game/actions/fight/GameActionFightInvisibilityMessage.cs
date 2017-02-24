

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
    public class GameActionFightInvisibilityMessage : AbstractGameActionMessage
    {
        public override ushort Id => 5821;
        
        
        public double targetId;
        public sbyte state;
        
        public GameActionFightInvisibilityMessage()
        {
        }
        
        public GameActionFightInvisibilityMessage(ushort actionId, double sourceId, double targetId, sbyte state)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.state = state;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(targetId);
            writer.WriteSByte(state);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            targetId = reader.ReadDouble();
            state = reader.ReadSByte();
        }
        
    }
    
}