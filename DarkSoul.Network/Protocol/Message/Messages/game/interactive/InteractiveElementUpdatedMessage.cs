

// Generated on 02/23/2017 16:53:50
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class InteractiveElementUpdatedMessage : NetworkMessage
    {
        public override ushort Id => 5708;
        
        
        public Types.InteractiveElement interactiveElement;
        
        public InteractiveElementUpdatedMessage()
        {
        }
        
        public InteractiveElementUpdatedMessage(Types.InteractiveElement interactiveElement)
        {
            this.interactiveElement = interactiveElement;
        }
        
        public override void Serialize(IWriter writer)
        {
            interactiveElement.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            interactiveElement = new Types.InteractiveElement();
            interactiveElement.Deserialize(reader);
        }
        
    }
    
}