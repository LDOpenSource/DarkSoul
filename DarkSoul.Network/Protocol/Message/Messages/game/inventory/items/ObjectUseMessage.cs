

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
    public class ObjectUseMessage : NetworkMessage
    {
        public override ushort Id => 3019;
        
        
        public uint objectUID;
        
        public ObjectUseMessage()
        {
        }
        
        public ObjectUseMessage(uint objectUID)
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