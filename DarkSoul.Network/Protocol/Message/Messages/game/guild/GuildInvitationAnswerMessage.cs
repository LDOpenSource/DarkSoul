

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
    public class GuildInvitationAnswerMessage : NetworkMessage
    {
        public override ushort Id => 5556;
        
        
        public bool accept;
        
        public GuildInvitationAnswerMessage()
        {
        }
        
        public GuildInvitationAnswerMessage(bool accept)
        {
            this.accept = accept;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteBoolean(accept);
        }
        
        public override void Deserialize(IReader reader)
        {
            accept = reader.ReadBoolean();
        }
        
    }
    
}