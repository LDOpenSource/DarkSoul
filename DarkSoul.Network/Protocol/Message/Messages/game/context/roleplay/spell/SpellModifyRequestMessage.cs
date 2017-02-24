

// Generated on 02/23/2017 16:53:44
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class SpellModifyRequestMessage : NetworkMessage
    {
        public override ushort Id => 6655;
        
        
        public ushort spellId;
        public short spellLevel;
        
        public SpellModifyRequestMessage()
        {
        }
        
        public SpellModifyRequestMessage(ushort spellId, short spellLevel)
        {
            this.spellId = spellId;
            this.spellLevel = spellLevel;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)spellId);
            writer.WriteShort(spellLevel);
        }
        
        public override void Deserialize(IReader reader)
        {
            spellId = reader.ReadVarUhShort();
            spellLevel = reader.ReadShort();
        }
        
    }
    
}