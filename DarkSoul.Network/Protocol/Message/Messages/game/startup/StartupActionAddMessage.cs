

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
    public class StartupActionAddMessage : NetworkMessage
    {
        public override ushort Id => 6538;
        
        
        public Types.StartupActionAddObject newAction;
        
        public StartupActionAddMessage()
        {
        }
        
        public StartupActionAddMessage(Types.StartupActionAddObject newAction)
        {
            this.newAction = newAction;
        }
        
        public override void Serialize(IWriter writer)
        {
            newAction.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            newAction = new Types.StartupActionAddObject();
            newAction.Deserialize(reader);
        }
        
    }
    
}