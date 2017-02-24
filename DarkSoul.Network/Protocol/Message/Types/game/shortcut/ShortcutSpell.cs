

// Generated on 02/23/2017 18:06:46
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class ShortcutSpell : Shortcut
    {
        public override short TypeId => 368;
        
        public ushort spellId;
        
        public ShortcutSpell()
        {
        }
        
        public ShortcutSpell(sbyte slot, ushort spellId)
         : base(slot)
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