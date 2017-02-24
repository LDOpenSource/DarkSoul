

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
    public class ObjectSetPositionMessage : NetworkMessage
    {
        public override ushort Id => 3021;
        
        
        public uint objectUID;
        public byte position;
        public uint quantity;
        
        public ObjectSetPositionMessage()
        {
        }
        
        public ObjectSetPositionMessage(uint objectUID, byte position, uint quantity)
        {
            this.objectUID = objectUID;
            this.position = position;
            this.quantity = quantity;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)objectUID);
            writer.WriteByte(position);
            writer.WriteVarInt((int)quantity);
        }
        
        public override void Deserialize(IReader reader)
        {
            objectUID = reader.ReadVarUhInt();
            position = reader.ReadByte();
            quantity = reader.ReadVarUhInt();
        }
        
    }
    
}