

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
    public class GuildInformationsMemberUpdateMessage : NetworkMessage
    {
        public override ushort Id => 5597;
        
        
        public Types.GuildMember member;
        
        public GuildInformationsMemberUpdateMessage()
        {
        }
        
        public GuildInformationsMemberUpdateMessage(Types.GuildMember member)
        {
            this.member = member;
        }
        
        public override void Serialize(IWriter writer)
        {
            member.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            member = new Types.GuildMember();
            member.Deserialize(reader);
        }
        
    }
    
}