

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
    public class GameActionFightDispellMessage : AbstractGameActionMessage
    {
        public override ushort Id => 5533;
        
        
        public double targetId;
        
        public GameActionFightDispellMessage()
        {
        }
        
        public GameActionFightDispellMessage(ushort actionId, double sourceId, double targetId)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(targetId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            targetId = reader.ReadDouble();
        }
        
    }
    
}