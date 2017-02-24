

// Generated on 02/23/2017 16:53:38
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class JobAllowMultiCraftRequestMessage : NetworkMessage
    {
        public override ushort Id => 5748;
        
        
        public bool enabled;
        
        public JobAllowMultiCraftRequestMessage()
        {
        }
        
        public JobAllowMultiCraftRequestMessage(bool enabled)
        {
            this.enabled = enabled;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteBoolean(enabled);
        }
        
        public override void Deserialize(IReader reader)
        {
            enabled = reader.ReadBoolean();
        }
        
    }
    
}