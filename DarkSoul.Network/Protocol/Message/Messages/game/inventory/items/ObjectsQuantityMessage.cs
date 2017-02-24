

// Generated on 02/23/2017 16:53:59
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ObjectsQuantityMessage : NetworkMessage
    {
        public override ushort Id => 6206;
        
        
        public IEnumerable<Types.ObjectItemQuantity> objectsUIDAndQty;
        
        public ObjectsQuantityMessage()
        {
        }
        
        public ObjectsQuantityMessage(IEnumerable<Types.ObjectItemQuantity> objectsUIDAndQty)
        {
            this.objectsUIDAndQty = objectsUIDAndQty;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)objectsUIDAndQty.Count());
            foreach (var entry in objectsUIDAndQty)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            objectsUIDAndQty = new Types.ObjectItemQuantity[limit];
            for (int i = 0; i < limit; i++)
            {
                 (objectsUIDAndQty as Types.ObjectItemQuantity[])[i] = new Types.ObjectItemQuantity();
                 (objectsUIDAndQty as Types.ObjectItemQuantity[])[i].Deserialize(reader);
            }
        }
        
    }
    
}