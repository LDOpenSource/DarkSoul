

// Generated on 02/23/2017 16:53:55
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ExchangeReadyMessage : NetworkMessage
    {
        public override ushort Id => 5511;
        
        
        public bool ready;
        public ushort step;
        
        public ExchangeReadyMessage()
        {
        }
        
        public ExchangeReadyMessage(bool ready, ushort step)
        {
            this.ready = ready;
            this.step = step;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteBoolean(ready);
            writer.WriteVarShort((int)step);
        }
        
        public override void Deserialize(IReader reader)
        {
            ready = reader.ReadBoolean();
            step = reader.ReadVarUhShort();
        }
        
    }
    
}