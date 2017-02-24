

// Generated on 02/23/2017 16:54:02
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ShortcutBarContentMessage : NetworkMessage
    {
        public override ushort Id => 6231;
        
        
        public sbyte barType;
        public IEnumerable<Types.Shortcut> shortcuts;
        
        public ShortcutBarContentMessage()
        {
        }
        
        public ShortcutBarContentMessage(sbyte barType, IEnumerable<Types.Shortcut> shortcuts)
        {
            this.barType = barType;
            this.shortcuts = shortcuts;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(barType);
            writer.WriteShort((short)shortcuts.Count());
            foreach (var entry in shortcuts)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            barType = reader.ReadSByte();
            var limit = reader.ReadUShort();
            shortcuts = new Types.Shortcut[limit];
            for (int i = 0; i < limit; i++)
            {
                 (shortcuts as Types.Shortcut[])[i] = ProtocolTypeManager.GetInstance<Types.Shortcut>(reader.ReadUShort());
                 (shortcuts as Types.Shortcut[])[i].Deserialize(reader);
            }
        }
        
    }
    
}