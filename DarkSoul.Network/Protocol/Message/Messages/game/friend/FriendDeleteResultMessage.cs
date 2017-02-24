

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
    public class FriendDeleteResultMessage : NetworkMessage
    {
        public override ushort Id => 5601;
        
        
        public bool success;
        public string name;
        
        public FriendDeleteResultMessage()
        {
        }
        
        public FriendDeleteResultMessage(bool success, string name)
        {
            this.success = success;
            this.name = name;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteBoolean(success);
            writer.WriteUTF(name);
        }
        
        public override void Deserialize(IReader reader)
        {
            success = reader.ReadBoolean();
            name = reader.ReadUTF();
        }
        
    }
    
}