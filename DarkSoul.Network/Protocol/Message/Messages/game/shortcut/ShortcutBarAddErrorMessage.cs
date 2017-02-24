

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
    public class ShortcutBarAddErrorMessage : NetworkMessage
    {
        public override ushort Id => 6227;
        
        
        public sbyte error;
        
        public ShortcutBarAddErrorMessage()
        {
        }
        
        public ShortcutBarAddErrorMessage(sbyte error)
        {
            this.error = error;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(error);
        }
        
        public override void Deserialize(IReader reader)
        {
            error = reader.ReadSByte();
        }
        
    }
    
}