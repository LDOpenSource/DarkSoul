

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
    public class GameActionFightSlideMessage : AbstractGameActionMessage
    {
        public override ushort Id => 5525;
        
        
        public double targetId;
        public short startCellId;
        public short endCellId;
        
        public GameActionFightSlideMessage()
        {
        }
        
        public GameActionFightSlideMessage(ushort actionId, double sourceId, double targetId, short startCellId, short endCellId)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.startCellId = startCellId;
            this.endCellId = endCellId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(targetId);
            writer.WriteShort(startCellId);
            writer.WriteShort(endCellId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            targetId = reader.ReadDouble();
            startCellId = reader.ReadShort();
            endCellId = reader.ReadShort();
        }
        
    }
    
}