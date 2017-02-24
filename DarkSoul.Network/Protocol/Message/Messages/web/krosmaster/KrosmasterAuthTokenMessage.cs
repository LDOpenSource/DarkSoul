

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
    public class KrosmasterAuthTokenMessage : NetworkMessage
    {
        public override ushort Id => 6351;
        
        
        public string token;
        
        public KrosmasterAuthTokenMessage()
        {
        }
        
        public KrosmasterAuthTokenMessage(string token)
        {
            this.token = token;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteUTF(token);
        }
        
        public override void Deserialize(IReader reader)
        {
            token = reader.ReadUTF();
        }
        
    }
    
}