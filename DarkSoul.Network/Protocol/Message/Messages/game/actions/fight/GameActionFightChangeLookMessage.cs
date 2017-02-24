

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
    public class GameActionFightChangeLookMessage : AbstractGameActionMessage
    {
        public override ushort Id => 5532;
        
        
        public double targetId;
        public Types.EntityLook entityLook;
        
        public GameActionFightChangeLookMessage()
        {
        }
        
        public GameActionFightChangeLookMessage(ushort actionId, double sourceId, double targetId, Types.EntityLook entityLook)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.entityLook = entityLook;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(targetId);
            entityLook.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            targetId = reader.ReadDouble();
            entityLook = new Types.EntityLook();
            entityLook.Deserialize(reader);
        }
        
    }
    
}