

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
    public class FriendUpdateMessage : NetworkMessage
    {
        public override ushort Id => 5924;
        
        
        public Types.FriendInformations friendUpdated;
        
        public FriendUpdateMessage()
        {
        }
        
        public FriendUpdateMessage(Types.FriendInformations friendUpdated)
        {
            this.friendUpdated = friendUpdated;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort(friendUpdated.TypeId);
            friendUpdated.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            friendUpdated = ProtocolTypeManager.GetInstance<Types.FriendInformations>(reader.ReadUShort());
            friendUpdated.Deserialize(reader);
        }
        
    }
    
}