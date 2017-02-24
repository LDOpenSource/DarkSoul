

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
    public class ObjectDeleteMessage : NetworkMessage
    {
        public override ushort Id => 3022;
        
        
        public uint objectUID;
        public uint quantity;
        
        public ObjectDeleteMessage()
        {
        }
        
        public ObjectDeleteMessage(uint objectUID, uint quantity)
        {
            this.objectUID = objectUID;
            this.quantity = quantity;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)objectUID);
            writer.WriteVarInt((int)quantity);
        }
        
        public override void Deserialize(IReader reader)
        {
            objectUID = reader.ReadVarUhInt();
            quantity = reader.ReadVarUhInt();
        }
        
    }
    
}