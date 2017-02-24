

// Generated on 02/23/2017 16:53:56
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ExchangeWaitingResultMessage : NetworkMessage
    {
        public override ushort Id => 5786;
        
        
        public bool bwait;
        
        public ExchangeWaitingResultMessage()
        {
        }
        
        public ExchangeWaitingResultMessage(bool bwait)
        {
            this.bwait = bwait;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteBoolean(bwait);
        }
        
        public override void Deserialize(IReader reader)
        {
            bwait = reader.ReadBoolean();
        }
        
    }
    
}