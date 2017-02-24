

// Generated on 02/23/2017 16:54:01
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class PopupWarningMessage : NetworkMessage
    {
        public override ushort Id => 6134;
        
        
        public byte lockDuration;
        public string author;
        public string content;
        
        public PopupWarningMessage()
        {
        }
        
        public PopupWarningMessage(byte lockDuration, string author, string content)
        {
            this.lockDuration = lockDuration;
            this.author = author;
            this.content = content;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteByte(lockDuration);
            writer.WriteUTF(author);
            writer.WriteUTF(content);
        }
        
        public override void Deserialize(IReader reader)
        {
            lockDuration = reader.ReadByte();
            author = reader.ReadUTF();
            content = reader.ReadUTF();
        }
        
    }
    
}