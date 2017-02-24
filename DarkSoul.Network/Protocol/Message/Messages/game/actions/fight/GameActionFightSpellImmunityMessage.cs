

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
    public class GameActionFightSpellImmunityMessage : AbstractGameActionMessage
    {
        public override ushort Id => 6221;
        
        
        public double targetId;
        public ushort spellId;
        
        public GameActionFightSpellImmunityMessage()
        {
        }
        
        public GameActionFightSpellImmunityMessage(ushort actionId, double sourceId, double targetId, ushort spellId)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.spellId = spellId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(targetId);
            writer.WriteVarShort((int)spellId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            targetId = reader.ReadDouble();
            spellId = reader.ReadVarUhShort();
        }
        
    }
    
}