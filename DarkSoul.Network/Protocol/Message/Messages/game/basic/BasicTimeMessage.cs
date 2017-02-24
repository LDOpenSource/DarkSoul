

// Generated on 02/23/2017 16:53:23
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class BasicTimeMessage : NetworkMessage
    {
        public override ushort Id => 175;
        
        
        public double timestamp;
        public short timezoneOffset;
        
        public BasicTimeMessage()
        {
        }
        
        public BasicTimeMessage(double timestamp, short timezoneOffset)
        {
            this.timestamp = timestamp;
            this.timezoneOffset = timezoneOffset;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteDouble(timestamp);
            writer.WriteShort(timezoneOffset);
        }
        
        public override void Deserialize(IReader reader)
        {
            timestamp = reader.ReadDouble();
            timezoneOffset = reader.ReadShort();
        }
        
    }
    
}