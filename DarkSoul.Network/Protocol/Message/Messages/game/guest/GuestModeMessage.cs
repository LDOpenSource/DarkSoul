

// Generated on 02/23/2017 16:53:47
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GuestModeMessage : NetworkMessage
    {
        public override ushort Id => 6505;
        
        
        public bool active;
        
        public GuestModeMessage()
        {
        }
        
        public GuestModeMessage(bool active)
        {
            this.active = active;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteBoolean(active);
        }
        
        public override void Deserialize(IReader reader)
        {
            active = reader.ReadBoolean();
        }
        
    }
    
}