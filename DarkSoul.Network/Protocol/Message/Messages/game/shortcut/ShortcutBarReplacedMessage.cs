

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
    public class ShortcutBarReplacedMessage : NetworkMessage
    {
        public override ushort Id => 6706;
        
        
        public sbyte barType;
        public Types.Shortcut shortcut;
        
        public ShortcutBarReplacedMessage()
        {
        }
        
        public ShortcutBarReplacedMessage(sbyte barType, Types.Shortcut shortcut)
        {
            this.barType = barType;
            this.shortcut = shortcut;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(barType);
            writer.WriteShort(shortcut.TypeId);
            shortcut.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            barType = reader.ReadSByte();
            shortcut = ProtocolTypeManager.GetInstance<Types.Shortcut>(reader.ReadUShort());
            shortcut.Deserialize(reader);
        }
        
    }
    
}