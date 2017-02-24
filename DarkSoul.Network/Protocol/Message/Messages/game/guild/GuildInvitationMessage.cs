

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
    public class GuildInvitationMessage : NetworkMessage
    {
        public override ushort Id => 5551;
        
        
        public double targetId;
        
        public GuildInvitationMessage()
        {
        }
        
        public GuildInvitationMessage(double targetId)
        {
            this.targetId = targetId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarLong(targetId);
        }
        
        public override void Deserialize(IReader reader)
        {
            targetId = reader.ReadVarUhLong();
        }
        
    }
    
}