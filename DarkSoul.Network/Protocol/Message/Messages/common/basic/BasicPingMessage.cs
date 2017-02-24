

// Generated on 02/23/2017 16:53:15
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class BasicPingMessage : NetworkMessage
    {
        public override ushort Id => 182;
        
        
        public bool quiet;
        
        public BasicPingMessage()
        {
        }
        
        public BasicPingMessage(bool quiet)
        {
            this.quiet = quiet;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteBoolean(quiet);
        }
        
        public override void Deserialize(IReader reader)
        {
            quiet = reader.ReadBoolean();
        }
        
    }
    
}