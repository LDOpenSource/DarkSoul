

// Generated on 02/23/2017 16:53:26
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ChatClientMultiMessage : ChatAbstractClientMessage
    {
        public override ushort Id => 861;
        
        
        public sbyte channel;
        
        public ChatClientMultiMessage()
        {
        }
        
        public ChatClientMultiMessage(string content, sbyte channel)
         : base(content)
        {
            this.channel = channel;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSByte(channel);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            channel = reader.ReadSByte();
        }
        
    }
    
}