

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
    public class BasicWhoIsNoMatchMessage : NetworkMessage
    {
        public override ushort Id => 179;
        
        
        public string search;
        
        public BasicWhoIsNoMatchMessage()
        {
        }
        
        public BasicWhoIsNoMatchMessage(string search)
        {
            this.search = search;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteUTF(search);
        }
        
        public override void Deserialize(IReader reader)
        {
            search = reader.ReadUTF();
        }
        
    }
    
}