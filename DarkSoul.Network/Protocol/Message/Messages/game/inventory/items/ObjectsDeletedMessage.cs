

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
    public class ObjectsDeletedMessage : NetworkMessage
    {
        public override ushort Id => 6034;
        
        
        public IEnumerable<uint> objectUID;
        
        public ObjectsDeletedMessage()
        {
        }
        
        public ObjectsDeletedMessage(IEnumerable<uint> objectUID)
        {
            this.objectUID = objectUID;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)objectUID.Count());
            foreach (var entry in objectUID)
            {
                 writer.WriteVarInt((int)entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            objectUID = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 (objectUID as uint[])[i] = reader.ReadVarUhInt();
            }
        }
        
    }
    
}