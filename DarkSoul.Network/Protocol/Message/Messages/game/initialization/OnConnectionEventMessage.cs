

// Generated on 02/23/2017 16:53:50
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class OnConnectionEventMessage : NetworkMessage
    {
        public override ushort Id => 5726;
        
        
        public sbyte eventType;
        
        public OnConnectionEventMessage()
        {
        }
        
        public OnConnectionEventMessage(sbyte eventType)
        {
            this.eventType = eventType;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(eventType);
        }
        
        public override void Deserialize(IReader reader)
        {
            eventType = reader.ReadSByte();
        }
        
    }
    
}