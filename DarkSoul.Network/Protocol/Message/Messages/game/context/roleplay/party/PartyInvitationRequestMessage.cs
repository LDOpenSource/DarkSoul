

// Generated on 02/23/2017 16:53:41
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class PartyInvitationRequestMessage : NetworkMessage
    {
        public override ushort Id => 5585;
        
        
        public string name;
        
        public PartyInvitationRequestMessage()
        {
        }
        
        public PartyInvitationRequestMessage(string name)
        {
            this.name = name;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteUTF(name);
        }
        
        public override void Deserialize(IReader reader)
        {
            name = reader.ReadUTF();
        }
        
    }
    
}