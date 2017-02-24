

// Generated on 02/23/2017 16:53:46
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class IgnoredAddRequestMessage : NetworkMessage
    {
        public override ushort Id => 5673;
        
        
        public string name;
        public bool session;
        
        public IgnoredAddRequestMessage()
        {
        }
        
        public IgnoredAddRequestMessage(string name, bool session)
        {
            this.name = name;
            this.session = session;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteUTF(name);
            writer.WriteBoolean(session);
        }
        
        public override void Deserialize(IReader reader)
        {
            name = reader.ReadUTF();
            session = reader.ReadBoolean();
        }
        
    }
    
}