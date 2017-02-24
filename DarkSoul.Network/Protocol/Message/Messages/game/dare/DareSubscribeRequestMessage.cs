

// Generated on 02/23/2017 16:53:45
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class DareSubscribeRequestMessage : NetworkMessage
    {
        public override ushort Id => 6666;
        
        
        public double dareId;
        public bool subscribe;
        
        public DareSubscribeRequestMessage()
        {
        }
        
        public DareSubscribeRequestMessage(double dareId, bool subscribe)
        {
            this.dareId = dareId;
            this.subscribe = subscribe;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteDouble(dareId);
            writer.WriteBoolean(subscribe);
        }
        
        public override void Deserialize(IReader reader)
        {
            dareId = reader.ReadDouble();
            subscribe = reader.ReadBoolean();
        }
        
    }
    
}