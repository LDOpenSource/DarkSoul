

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
    public class ChatClientPrivateMessage : ChatAbstractClientMessage
    {
        public override ushort Id => 851;
        
        
        public string receiver;
        
        public ChatClientPrivateMessage()
        {
        }
        
        public ChatClientPrivateMessage(string content, string receiver)
         : base(content)
        {
            this.receiver = receiver;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(receiver);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            receiver = reader.ReadUTF();
        }
        
    }
    
}