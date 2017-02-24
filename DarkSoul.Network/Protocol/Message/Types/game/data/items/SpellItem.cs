

// Generated on 02/23/2017 18:06:44
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class SpellItem : Item
    {
        public override short TypeId => 49;
        
        public int spellId;
        public short spellLevel;
        
        public SpellItem()
        {
        }
        
        public SpellItem(int spellId, short spellLevel)
        {
            this.spellId = spellId;
            this.spellLevel = spellLevel;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteInt(spellId);
            writer.WriteShort(spellLevel);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            spellId = reader.ReadInt();
            spellLevel = reader.ReadShort();
        }
        
    }
    
}