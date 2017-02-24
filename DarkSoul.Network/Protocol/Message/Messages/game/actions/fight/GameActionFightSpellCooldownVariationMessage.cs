

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
    public class GameActionFightSpellCooldownVariationMessage : AbstractGameActionMessage
    {
        public override ushort Id => 6219;
        
        
        public double targetId;
        public ushort spellId;
        public short value;
        
        public GameActionFightSpellCooldownVariationMessage()
        {
        }
        
        public GameActionFightSpellCooldownVariationMessage(ushort actionId, double sourceId, double targetId, ushort spellId, short value)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.spellId = spellId;
            this.value = value;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(targetId);
            writer.WriteVarShort((int)spellId);
            writer.WriteVarShort((int)value);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            targetId = reader.ReadDouble();
            spellId = reader.ReadVarUhShort();
            value = reader.ReadVarShort();
        }
        
    }
    
}