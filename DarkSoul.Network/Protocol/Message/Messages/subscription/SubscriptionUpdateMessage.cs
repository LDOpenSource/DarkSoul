

// Generated on 02/23/2017 16:54:04
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class SubscriptionUpdateMessage : NetworkMessage
    {
        public override ushort Id => 6616;
        
        
        public double timestamp;
        
        public SubscriptionUpdateMessage()
        {
        }
        
        public SubscriptionUpdateMessage(double timestamp)
        {
            this.timestamp = timestamp;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteDouble(timestamp);
        }
        
        public override void Deserialize(IReader reader)
        {
            timestamp = reader.ReadDouble();
        }
        
    }
    
}