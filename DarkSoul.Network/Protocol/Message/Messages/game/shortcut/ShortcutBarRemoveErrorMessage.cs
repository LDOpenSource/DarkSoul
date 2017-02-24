

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
    public class ShortcutBarRemoveErrorMessage : NetworkMessage
    {
        public override ushort Id => 6222;
        
        
        public sbyte error;
        
        public ShortcutBarRemoveErrorMessage()
        {
        }
        
        public ShortcutBarRemoveErrorMessage(sbyte error)
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