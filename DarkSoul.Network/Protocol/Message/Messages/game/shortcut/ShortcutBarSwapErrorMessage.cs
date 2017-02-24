

// Generated on 02/23/2017 16:54:03
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ShortcutBarSwapErrorMessage : NetworkMessage
    {
        public override ushort Id => 6226;
        
        
        public sbyte error;
        
        public ShortcutBarSwapErrorMessage()
        {
        }
        
        public ShortcutBarSwapErrorMessage(sbyte error)
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