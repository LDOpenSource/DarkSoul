

// Generated on 02/23/2017 16:53:22
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class AllianceInvitationStateRecruterMessage : NetworkMessage
    {
        public override ushort Id => 6396;
        
        
        public string recrutedName;
        public sbyte invitationState;
        
        public AllianceInvitationStateRecruterMessage()
        {
        }
        
        public AllianceInvitationStateRecruterMessage(string recrutedName, sbyte invitationState)
        {
            this.recrutedName = recrutedName;
            this.invitationState = invitationState;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteUTF(recrutedName);
            writer.WriteSByte(invitationState);
        }
        
        public override void Deserialize(IReader reader)
        {
            recrutedName = reader.ReadUTF();
            invitationState = reader.ReadSByte();
        }
        
    }
    
}