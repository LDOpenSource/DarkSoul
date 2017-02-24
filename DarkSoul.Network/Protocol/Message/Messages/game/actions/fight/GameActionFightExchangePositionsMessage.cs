

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
    public class GameActionFightExchangePositionsMessage : AbstractGameActionMessage
    {
        public override ushort Id => 5527;
        
        
        public double targetId;
        public short casterCellId;
        public short targetCellId;
        
        public GameActionFightExchangePositionsMessage()
        {
        }
        
        public GameActionFightExchangePositionsMessage(ushort actionId, double sourceId, double targetId, short casterCellId, short targetCellId)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.casterCellId = casterCellId;
            this.targetCellId = targetCellId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(targetId);
            writer.WriteShort(casterCellId);
            writer.WriteShort(targetCellId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            targetId = reader.ReadDouble();
            casterCellId = reader.ReadShort();
            targetCellId = reader.ReadShort();
        }
        
    }
    
}