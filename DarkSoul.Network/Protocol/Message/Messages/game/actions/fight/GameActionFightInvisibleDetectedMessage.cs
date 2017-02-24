

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
    public class GameActionFightInvisibleDetectedMessage : AbstractGameActionMessage
    {
        public override ushort Id => 6320;
        
        
        public double targetId;
        public short cellId;
        
        public GameActionFightInvisibleDetectedMessage()
        {
        }
        
        public GameActionFightInvisibleDetectedMessage(ushort actionId, double sourceId, double targetId, short cellId)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.cellId = cellId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(targetId);
            writer.WriteShort(cellId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            targetId = reader.ReadDouble();
            cellId = reader.ReadShort();
        }
        
    }
    
}