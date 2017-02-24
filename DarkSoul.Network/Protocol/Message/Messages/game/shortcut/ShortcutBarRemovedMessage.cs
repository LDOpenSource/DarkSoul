

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
    public class ShortcutBarRemovedMessage : NetworkMessage
    {
        public override ushort Id => 6224;
        
        
        public sbyte barType;
        public sbyte slot;
        
        public ShortcutBarRemovedMessage()
        {
        }
        
        public ShortcutBarRemovedMessage(sbyte barType, sbyte slot)
        {
            this.barType = barType;
            this.slot = slot;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(barType);
            writer.WriteSByte(slot);
        }
        
        public override void Deserialize(IReader reader)
        {
            barType = reader.ReadSByte();
            slot = reader.ReadSByte();
        }
        
    }
    
}