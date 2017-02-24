

// Generated on 02/23/2017 16:54:05
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class MailStatusMessage : NetworkMessage
    {
        public override ushort Id => 6275;
        
        
        public ushort unread;
        public ushort total;
        
        public MailStatusMessage()
        {
        }
        
        public MailStatusMessage(ushort unread, ushort total)
        {
            this.unread = unread;
            this.total = total;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)unread);
            writer.WriteVarShort((int)total);
        }
        
        public override void Deserialize(IReader reader)
        {
            unread = reader.ReadVarUhShort();
            total = reader.ReadVarUhShort();
        }
        
    }
    
}