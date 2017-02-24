

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
    public class StorageObjectsRemoveMessage : NetworkMessage
    {
        public override ushort Id => 6035;
        
        
        public IEnumerable<uint> objectUIDList;
        
        public StorageObjectsRemoveMessage()
        {
        }
        
        public StorageObjectsRemoveMessage(IEnumerable<uint> objectUIDList)
        {
            this.objectUIDList = objectUIDList;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)objectUIDList.Count());
            foreach (var entry in objectUIDList)
            {
                 writer.WriteVarInt((int)entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            objectUIDList = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 (objectUIDList as uint[])[i] = reader.ReadVarUhInt();
            }
        }
        
    }
    
}