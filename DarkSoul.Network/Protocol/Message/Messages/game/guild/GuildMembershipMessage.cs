

// Generated on 02/23/2017 16:53:48
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GuildMembershipMessage : GuildJoinedMessage
    {
        public override ushort Id => 5835;
        
        
        
        public GuildMembershipMessage()
        {
        }
        
        public GuildMembershipMessage(Types.GuildInformations guildInfo, uint memberRights)
         : base(guildInfo, memberRights)
        {
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
        }
        
    }
    
}