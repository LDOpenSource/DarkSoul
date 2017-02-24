

// Generated on 02/23/2017 16:53:24
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class BasicWhoAmIRequestMessage : NetworkMessage
    {
        public override ushort Id => 5664;
        
        
        public bool verbose;
        
        public BasicWhoAmIRequestMessage()
        {
        }
        
        public BasicWhoAmIRequestMessage(bool verbose)
        {
            this.verbose = verbose;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteBoolean(verbose);
        }
        
        public override void Deserialize(IReader reader)
        {
            verbose = reader.ReadBoolean();
        }
        
    }
    
}