

// Generated on 02/23/2017 16:53:37
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class TeleportHavenBagAnswerMessage : NetworkMessage
    {
        public override ushort Id => 6646;
        
        
        public bool accept;
        
        public TeleportHavenBagAnswerMessage()
        {
        }
        
        public TeleportHavenBagAnswerMessage(bool accept)
        {
            this.accept = accept;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteBoolean(accept);
        }
        
        public override void Deserialize(IReader reader)
        {
            accept = reader.ReadBoolean();
        }
        
    }
    
}