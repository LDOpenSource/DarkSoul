

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
    public class SpellModifySuccessMessage : NetworkMessage
    {
        public override ushort Id => 6654;
        
        
        public int spellId;
        public short spellLevel;
        
        public SpellModifySuccessMessage()
        {
        }
        
        public SpellModifySuccessMessage(int spellId, short spellLevel)
        {
            this.spellId = spellId;
            this.spellLevel = spellLevel;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteInt(spellId);
            writer.WriteShort(spellLevel);
        }
        
        public override void Deserialize(IReader reader)
        {
            spellId = reader.ReadInt();
            spellLevel = reader.ReadShort();
        }
        
    }
    
}