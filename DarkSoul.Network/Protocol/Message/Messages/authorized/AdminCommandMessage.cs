

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
    public class AdminCommandMessage : NetworkMessage
    {
        public override ushort Id => 76;
        
        
        public string content;
        
        public AdminCommandMessage()
        {
        }
        
        public AdminCommandMessage(string content)
        {
            this.content = content;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteUTF(content);
        }
        
        public override void Deserialize(IReader reader)
        {
            content = reader.ReadUTF();
        }
        
    }
    
}