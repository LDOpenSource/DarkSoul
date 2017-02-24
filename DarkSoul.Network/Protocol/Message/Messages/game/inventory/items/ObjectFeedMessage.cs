

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
    public class ObjectFeedMessage : NetworkMessage
    {
        public override ushort Id => 6290;
        
        
        public uint objectUID;
        public uint foodUID;
        public uint foodQuantity;
        
        public ObjectFeedMessage()
        {
        }
        
        public ObjectFeedMessage(uint objectUID, uint foodUID, uint foodQuantity)
        {
            this.objectUID = objectUID;
            this.foodUID = foodUID;
            this.foodQuantity = foodQuantity;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)objectUID);
            writer.WriteVarInt((int)foodUID);
            writer.WriteVarInt((int)foodQuantity);
        }
        
        public override void Deserialize(IReader reader)
        {
            objectUID = reader.ReadVarUhInt();
            foodUID = reader.ReadVarUhInt();
            foodQuantity = reader.ReadVarUhInt();
        }
        
    }
    
}