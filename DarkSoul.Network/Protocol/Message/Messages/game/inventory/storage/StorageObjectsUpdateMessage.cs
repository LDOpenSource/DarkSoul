

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
    public class StorageObjectsUpdateMessage : NetworkMessage
    {
        public override ushort Id => 6036;
        
        
        public IEnumerable<Types.ObjectItem> objectList;
        
        public StorageObjectsUpdateMessage()
        {
        }
        
        public StorageObjectsUpdateMessage(IEnumerable<Types.ObjectItem> objectList)
        {
            this.objectList = objectList;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)objectList.Count());
            foreach (var entry in objectList)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            objectList = new Types.ObjectItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 (objectList as Types.ObjectItem[])[i] = new Types.ObjectItem();
                 (objectList as Types.ObjectItem[])[i].Deserialize(reader);
            }
        }
        
    }
    
}