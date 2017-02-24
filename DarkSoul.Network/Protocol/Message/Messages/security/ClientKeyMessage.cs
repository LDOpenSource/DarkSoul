

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
    public class ClientKeyMessage : NetworkMessage
    {
        public override ushort Id => 5607;
        
        
        public string key;
        
        public ClientKeyMessage()
        {
        }
        
        public ClientKeyMessage(string key)
        {
            this.key = key;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteUTF(key);
        }
        
        public override void Deserialize(IReader reader)
        {
            key = reader.ReadUTF();
        }
        
    }
    
}