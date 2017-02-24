

// Generated on 02/23/2017 16:53:57
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class InventoryContentMessage : NetworkMessage
    {
        public override ushort Id => 3016;
        
        
        public IEnumerable<Types.ObjectItem> objects;
        public double kamas;
        
        public InventoryContentMessage()
        {
        }
        
        public InventoryContentMessage(IEnumerable<Types.ObjectItem> objects, double kamas)
        {
            this.objects = objects;
            this.kamas = kamas;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)objects.Count());
            foreach (var entry in objects)
            {
                 entry.Serialize(writer);
            }
            writer.WriteVarLong(kamas);
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            objects = new Types.ObjectItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 (objects as Types.ObjectItem[])[i] = new Types.ObjectItem();
                 (objects as Types.ObjectItem[])[i].Deserialize(reader);
            }
            kamas = reader.ReadVarUhLong();
        }
        
    }
    
}