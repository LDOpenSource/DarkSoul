

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
    public class FriendsListMessage : NetworkMessage
    {
        public override ushort Id => 4002;
        
        
        public IEnumerable<Types.FriendInformations> friendsList;
        
        public FriendsListMessage()
        {
        }
        
        public FriendsListMessage(IEnumerable<Types.FriendInformations> friendsList)
        {
            this.friendsList = friendsList;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)friendsList.Count());
            foreach (var entry in friendsList)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            friendsList = new Types.FriendInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (friendsList as Types.FriendInformations[])[i] = ProtocolTypeManager.GetInstance<Types.FriendInformations>(reader.ReadUShort());
                 (friendsList as Types.FriendInformations[])[i].Deserialize(reader);
            }
        }
        
    }
    
}