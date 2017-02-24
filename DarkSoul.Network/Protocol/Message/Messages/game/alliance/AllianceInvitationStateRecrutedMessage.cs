

// Generated on 02/23/2017 16:53:21
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class AllianceInvitationStateRecrutedMessage : NetworkMessage
    {
        public override ushort Id => 6392;
        
        
        public sbyte invitationState;
        
        public AllianceInvitationStateRecrutedMessage()
        {
        }
        
        public AllianceInvitationStateRecrutedMessage(sbyte invitationState)
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