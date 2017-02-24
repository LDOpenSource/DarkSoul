

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
    public class BasicWhoIsRequestMessage : NetworkMessage
    {
        public override ushort Id => 181;
        
        
        public bool verbose;
        public string search;
        
        public BasicWhoIsRequestMessage()
        {
        }
        
        public BasicWhoIsRequestMessage(bool verbose, string search)
        {
            this.verbose = verbose;
            this.search = search;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteBoolean(verbose);
            writer.WriteUTF(search);
        }
        
        public override void Deserialize(IReader reader)
        {
            verbose = reader.ReadBoolean();
            search = reader.ReadUTF();
        }
        
    }
    
}