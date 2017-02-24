

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
    public class FriendJoinRequestMessage : NetworkMessage
    {
        public override ushort Id => 5605;
        
        
        public string name;
        
        public FriendJoinRequestMessage()
        {
        }
        
        public FriendJoinRequestMessage(string name)
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