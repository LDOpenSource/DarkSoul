

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
    public class FriendDeleteRequestMessage : NetworkMessage
    {
        public override ushort Id => 5603;
        
        
        public int accountId;
        
        public FriendDeleteRequestMessage()
        {
        }
        
        public FriendDeleteRequestMessage(int accountId)
        {
            this.accountId = accountId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteInt(accountId);
        }
        
        public override void Deserialize(IReader reader)
        {
            accountId = reader.ReadInt();
        }
        
    }
    
}