

// Generated on 02/23/2017 16:53:32
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class MountRidingMessage : NetworkMessage
    {
        public override ushort Id => 5967;
        
        
        public bool isRiding;
        
        public MountRidingMessage()
        {
        }
        
        public MountRidingMessage(bool isRiding)
        {
            this.isRiding = isRiding;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteBoolean(isRiding);
        }
        
        public override void Deserialize(IReader reader)
        {
            isRiding = reader.ReadBoolean();
        }
        
    }
    
}