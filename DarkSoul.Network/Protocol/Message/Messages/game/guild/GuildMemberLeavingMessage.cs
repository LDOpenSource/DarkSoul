

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
    public class GuildMemberLeavingMessage : NetworkMessage
    {
        public override ushort Id => 5923;
        
        
        public bool kicked;
        public double memberId;
        
        public GuildMemberLeavingMessage()
        {
        }
        
        public GuildMemberLeavingMessage(bool kicked, double memberId)
        {
            this.kicked = kicked;
            this.memberId = memberId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteBoolean(kicked);
            writer.WriteVarLong(memberId);
        }
        
        public override void Deserialize(IReader reader)
        {
            kicked = reader.ReadBoolean();
            memberId = reader.ReadVarUhLong();
        }
        
    }
    
}