

// Generated on 02/23/2017 16:54:00
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class SpellListMessage : NetworkMessage
    {
        public override ushort Id => 1200;
        
        
        public bool spellPrevisualization;
        public IEnumerable<Types.SpellItem> spells;
        
        public SpellListMessage()
        {
        }
        
        public SpellListMessage(bool spellPrevisualization, IEnumerable<Types.SpellItem> spells)
        {
            this.spellPrevisualization = spellPrevisualization;
            this.spells = spells;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteBoolean(spellPrevisualization);
            writer.WriteShort((short)spells.Count());
            foreach (var entry in spells)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            spellPrevisualization = reader.ReadBoolean();
            var limit = reader.ReadUShort();
            spells = new Types.SpellItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 (spells as Types.SpellItem[])[i] = new Types.SpellItem();
                 (spells as Types.SpellItem[])[i].Deserialize(reader);
            }
        }
        
    }
    
}