

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
    public class HaapiApiKeyRequestMessage : NetworkMessage
    {
        public override ushort Id => 6648;
        
        
        public sbyte keyType;
        
        public HaapiApiKeyRequestMessage()
        {
        }
        
        public HaapiApiKeyRequestMessage(sbyte keyType)
        {
            this.keyType = keyType;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(keyType);
        }
        
        public override void Deserialize(IReader reader)
        {
            keyType = reader.ReadSByte();
        }
        
    }
    
}