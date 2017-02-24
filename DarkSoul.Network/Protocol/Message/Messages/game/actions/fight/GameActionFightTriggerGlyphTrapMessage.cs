

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
    public class GameActionFightTriggerGlyphTrapMessage : AbstractGameActionMessage
    {
        public override ushort Id => 5741;
        
        
        public short markId;
        public double triggeringCharacterId;
        public ushort triggeredSpellId;
        
        public GameActionFightTriggerGlyphTrapMessage()
        {
        }
        
        public GameActionFightTriggerGlyphTrapMessage(ushort actionId, double sourceId, short markId, double triggeringCharacterId, ushort triggeredSpellId)
         : base(actionId, sourceId)
        {
            this.markId = markId;
            this.triggeringCharacterId = triggeringCharacterId;
            this.triggeredSpellId = triggeredSpellId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(markId);
            writer.WriteDouble(triggeringCharacterId);
            writer.WriteVarShort((int)triggeredSpellId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            markId = reader.ReadShort();
            triggeringCharacterId = reader.ReadDouble();
            triggeredSpellId = reader.ReadVarUhShort();
        }
        
    }
    
}