

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
    public class StorageObjectRemoveMessage : NetworkMessage
    {
        public override ushort Id => 5648;
        
        
        public uint objectUID;
        
        public StorageObjectRemoveMessage()
        {
        }
        
        public StorageObjectRemoveMessage(uint objectUID)
        {
            this.objectUID = objectUID;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)objectUID);
        }
        
        public override void Deserialize(IReader reader)
        {
            objectUID = reader.ReadVarUhInt();
        }
        
    }
    
}