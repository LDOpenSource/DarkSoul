

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
    public class GuildInvitationStateRecrutedMessage : NetworkMessage
    {
        public override ushort Id => 5548;
        
        
        public sbyte invitationState;
        
        public GuildInvitationStateRecrutedMessage()
        {
        }
        
        public GuildInvitationStateRecrutedMessage(sbyte invitationState)
        {
            this.invitationState = invitationState;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(invitationState);
        }
        
        public override void Deserialize(IReader reader)
        {
            invitationState = reader.ReadSByte();
        }
        
    }
    
}