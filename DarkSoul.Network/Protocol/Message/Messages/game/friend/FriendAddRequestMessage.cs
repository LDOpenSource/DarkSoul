

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
    public class FriendAddRequestMessage : NetworkMessage
    {
        public override ushort Id => 4004;
        
        
        public string name;
        
        public FriendAddRequestMessage()
        {
        }
        
        public FriendAddRequestMessage(string name)
        {
            this.name = name;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteUTF(name);
        }
        
        public override void Deserialize(IReader reader)
        {
            name = reader.ReadUTF();
        }
        
    }
    
}