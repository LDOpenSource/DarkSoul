

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
    public class CheckFileRequestMessage : NetworkMessage
    {
        public override ushort Id => 6154;
        
        
        public string filename;
        public sbyte type;
        
        public CheckFileRequestMessage()
        {
        }
        
        public CheckFileRequestMessage(string filename, sbyte type)
        {
            this.filename = filename;
            this.type = type;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteUTF(filename);
            writer.WriteSByte(type);
        }
        
        public override void Deserialize(IReader reader)
        {
            filename = reader.ReadUTF();
            type = reader.ReadSByte();
        }
        
    }
    
}