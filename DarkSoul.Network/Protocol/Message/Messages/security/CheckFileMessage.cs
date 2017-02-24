

// Generated on 02/23/2017 16:54:04
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class CheckFileMessage : NetworkMessage
    {
        public override ushort Id => 6156;
        
        
        public string filenameHash;
        public sbyte type;
        public string value;
        
        public CheckFileMessage()
        {
        }
        
        public CheckFileMessage(string filenameHash, sbyte type, string value)
        {
            this.filenameHash = filenameHash;
            this.type = type;
            this.value = value;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteUTF(filenameHash);
            writer.WriteSByte(type);
            writer.WriteUTF(value);
        }
        
        public override void Deserialize(IReader reader)
        {
            filenameHash = reader.ReadUTF();
            type = reader.ReadSByte();
            value = reader.ReadUTF();
        }
        
    }
    
}