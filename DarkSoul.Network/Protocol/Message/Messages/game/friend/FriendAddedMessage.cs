

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
    public class FriendAddedMessage : NetworkMessage
    {
        public override ushort Id => 5599;
        
        
        public Types.FriendInformations friendAdded;
        
        public FriendAddedMessage()
        {
        }
        
        public FriendAddedMessage(Types.FriendInformations friendAdded)
        {
            this.friendAdded = friendAdded;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort(friendAdded.TypeId);
            friendAdded.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            friendAdded = ProtocolTypeManager.GetInstance<Types.FriendInformations>(reader.ReadUShort());
            friendAdded.Deserialize(reader);
        }
        
    }
    
}