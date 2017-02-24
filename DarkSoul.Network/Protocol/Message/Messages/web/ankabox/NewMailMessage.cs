

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
    public class NewMailMessage : MailStatusMessage
    {
        public override ushort Id => 6292;
        
        
        public IEnumerable<int> sendersAccountId;
        
        public NewMailMessage()
        {
        }
        
        public NewMailMessage(ushort unread, ushort total, IEnumerable<int> sendersAccountId)
         : base(unread, total)
        {
            this.sendersAccountId = sendersAccountId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort((short)sendersAccountId.Count());
            foreach (var entry in sendersAccountId)
            {
                 writer.WriteInt(entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            var limit = reader.ReadUShort();
            sendersAccountId = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 (sendersAccountId as int[])[i] = reader.ReadInt();
            }
        }
        
    }
    
}