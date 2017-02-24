

// Generated on 02/23/2017 16:53:15
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ConsoleMessage : NetworkMessage
    {
        public override ushort Id => 75;
        
        
        public sbyte type;
        public string content;
        
        public ConsoleMessage()
        {
        }
        
        public ConsoleMessage(sbyte type, string content)
        {
            this.type = type;
            this.content = content;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(type);
            writer.WriteUTF(content);
        }
        
        public override void Deserialize(IReader reader)
        {
            type = reader.ReadSByte();
            content = reader.ReadUTF();
        }
        
    }
    
}