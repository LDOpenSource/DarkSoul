

// Generated on 02/23/2017 16:53:53
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ExchangeIsReadyMessage : NetworkMessage
    {
        public override ushort Id => 5509;
        
        
        public double id;
        public bool ready;
        
        public ExchangeIsReadyMessage()
        {
        }
        
        public ExchangeIsReadyMessage(double id, bool ready)
        {
            this.id = id;
            this.ready = ready;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteDouble(id);
            writer.WriteBoolean(ready);
        }
        
        public override void Deserialize(IReader reader)
        {
            id = reader.ReadDouble();
            ready = reader.ReadBoolean();
        }
        
    }
    
}