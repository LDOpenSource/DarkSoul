

// Generated on 02/23/2017 16:53:58
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ObjectModifiedMessage : NetworkMessage
    {
        public override ushort Id => 3029;
        
        
        public Types.ObjectItem @object;
        
        public ObjectModifiedMessage()
        {
        }
        
        public ObjectModifiedMessage(Types.ObjectItem @object)
        {
            this.@object = @object;
        }
        
        public override void Serialize(IWriter writer)
        {
            @object.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            @object = new Types.ObjectItem();
            @object.Deserialize(reader);
        }
        
    }
    
}