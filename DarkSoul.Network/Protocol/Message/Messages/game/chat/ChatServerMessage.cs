

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
    public class ChatServerMessage : ChatAbstractServerMessage
    {
        public override ushort Id => 881;
        
        
        public double senderId;
        public string senderName;
        public int senderAccountId;
        
        public ChatServerMessage()
        {
        }
        
        public ChatServerMessage(sbyte channel, string content, int timestamp, string fingerprint, double senderId, string senderName, int senderAccountId)
         : base(channel, content, timestamp, fingerprint)
        {
            this.senderId = senderId;
            this.senderName = senderName;
            this.senderAccountId = senderAccountId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(senderId);
            writer.WriteUTF(senderName);
            writer.WriteInt(senderAccountId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            senderId = reader.ReadDouble();
            senderName = reader.ReadUTF();
            senderAccountId = reader.ReadInt();
        }
        
    }
    
}