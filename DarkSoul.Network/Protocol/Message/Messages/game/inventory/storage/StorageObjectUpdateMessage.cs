

// Generated on 02/23/2017 16:54:00
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class StorageObjectUpdateMessage : NetworkMessage
    {
        public override ushort Id => 5647;
        
        
        public Types.ObjectItem @object;
        
        public StorageObjectUpdateMessage()
        {
        }
        
        public StorageObjectUpdateMessage(Types.ObjectItem @object)
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