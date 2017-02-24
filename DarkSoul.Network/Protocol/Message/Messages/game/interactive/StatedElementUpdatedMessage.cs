

// Generated on 02/23/2017 16:53:51
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class StatedElementUpdatedMessage : NetworkMessage
    {
        public override ushort Id => 5709;
        
        
        public Types.StatedElement statedElement;
        
        public StatedElementUpdatedMessage()
        {
        }
        
        public StatedElementUpdatedMessage(Types.StatedElement statedElement)
        {
            this.statedElement = statedElement;
        }
        
        public override void Serialize(IWriter writer)
        {
            statedElement.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            statedElement = new Types.StatedElement();
            statedElement.Deserialize(reader);
        }
        
    }
    
}