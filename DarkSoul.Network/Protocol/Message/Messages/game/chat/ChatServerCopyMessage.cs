

// Generated on 02/23/2017 16:53:27
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ChatServerCopyMessage : ChatAbstractServerMessage
    {
        public override ushort Id => 882;
        
        
        public double receiverId;
        public string receiverName;
        
        public ChatServerCopyMessage()
        {
        }
        
        public ChatServerCopyMessage(sbyte channel, string content, int timestamp, string fingerprint, double receiverId, string receiverName)
         : base(channel, content, timestamp, fingerprint)
        {
            this.receiverId = receiverId;
            this.receiverName = receiverName;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(receiverId);
            writer.WriteUTF(receiverName);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            receiverId = reader.ReadVarUhLong();
            receiverName = reader.ReadUTF();
        }
        
    }
    
}