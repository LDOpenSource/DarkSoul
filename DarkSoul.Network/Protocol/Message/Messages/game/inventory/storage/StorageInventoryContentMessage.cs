

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
    public class StorageInventoryContentMessage : InventoryContentMessage
    {
        public override ushort Id => 5646;
        
        
        
        public StorageInventoryContentMessage()
        {
        }
        
        public StorageInventoryContentMessage(IEnumerable<Types.ObjectItem> objects, double kamas)
         : base(objects, kamas)
        {
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
        }
        
    }
    
}