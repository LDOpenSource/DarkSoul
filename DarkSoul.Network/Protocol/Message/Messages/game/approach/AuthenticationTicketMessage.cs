

// Generated on 02/23/2017 16:53:23
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class AuthenticationTicketMessage : NetworkMessage
    {
        public override ushort Id => 110;
        
        
        public string lang;
        public string ticket;
        
        public AuthenticationTicketMessage()
        {
        }
        
        public AuthenticationTicketMessage(string lang, string ticket)
        {
            this.lang = lang;
            this.ticket = ticket;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteUTF(lang);
            writer.WriteUTF(ticket);
        }
        
        public override void Deserialize(IReader reader)
        {
            lang = reader.ReadUTF();
            ticket = reader.ReadUTF();
        }
        
    }
    
}