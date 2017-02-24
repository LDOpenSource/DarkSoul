

// Generated on 02/23/2017 16:53:54
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ExchangeObjectMessage : NetworkMessage
    {
        public override ushort Id => 5515;
        
        
        public bool remote;
        
        public ExchangeObjectMessage()
        {
        }
        
        public ExchangeObjectMessage(bool remote)
        {
            this.remote = remote;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteBoolean(remote);
        }
        
        public override void Deserialize(IReader reader)
        {
            remote = reader.ReadBoolean();
        }
        
    }
    
}