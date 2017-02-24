

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
    public class HaapiApiKeyMessage : NetworkMessage
    {
        public override ushort Id => 6649;
        
        
        public sbyte keyType;
        public string token;
        
        public HaapiApiKeyMessage()
        {
        }
        
        public HaapiApiKeyMessage(sbyte keyType, string token)
        {
            this.keyType = keyType;
            this.token = token;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(keyType);
            writer.WriteUTF(token);
        }
        
        public override void Deserialize(IReader reader)
        {
            keyType = reader.ReadSByte();
            token = reader.ReadUTF();
        }
        
    }
    
}