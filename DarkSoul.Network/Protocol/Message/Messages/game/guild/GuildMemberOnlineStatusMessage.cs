

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
    public class GuildMemberOnlineStatusMessage : NetworkMessage
    {
        public override ushort Id => 6061;
        
        
        public double memberId;
        public bool online;
        
        public GuildMemberOnlineStatusMessage()
        {
        }
        
        public GuildMemberOnlineStatusMessage(double memberId, bool online)
        {
            this.memberId = memberId;
            this.online = online;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarLong(memberId);
            writer.WriteBoolean(online);
        }
        
        public override void Deserialize(IReader reader)
        {
            memberId = reader.ReadVarUhLong();
            online = reader.ReadBoolean();
        }
        
    }
    
}