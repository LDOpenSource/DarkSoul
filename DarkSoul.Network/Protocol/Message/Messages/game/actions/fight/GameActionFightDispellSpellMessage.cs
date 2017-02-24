

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
    public class GameActionFightDispellSpellMessage : GameActionFightDispellMessage
    {
        public override ushort Id => 6176;
        
        
        public ushort spellId;
        
        public GameActionFightDispellSpellMessage()
        {
        }
        
        public GameActionFightDispellSpellMessage(ushort actionId, double sourceId, double targetId, ushort spellId)
         : base(actionId, sourceId, targetId)
        {
            this.spellId = spellId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((int)spellId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            spellId = reader.ReadVarUhShort();
        }
        
    }
    
}