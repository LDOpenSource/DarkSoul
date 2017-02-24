

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
    public class ObjectMovementMessage : NetworkMessage
    {
        public override ushort Id => 3010;
        
        
        public uint objectUID;
        public byte position;
        
        public ObjectMovementMessage()
        {
        }
        
        public ObjectMovementMessage(uint objectUID, byte position)
        {
            this.objectUID = objectUID;
            this.position = position;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)objectUID);
            writer.WriteByte(position);
        }
        
        public override void Deserialize(IReader reader)
        {
            objectUID = reader.ReadVarUhInt();
            position = reader.ReadByte();
        }
        
    }
    
}