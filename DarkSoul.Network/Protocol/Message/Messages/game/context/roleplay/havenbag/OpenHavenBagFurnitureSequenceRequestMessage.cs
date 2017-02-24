

// Generated on 02/23/2017 16:53:36
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class OpenHavenBagFurnitureSequenceRequestMessage : NetworkMessage
    {
        public override ushort Id => 6635;
        
        
        
        public OpenHavenBagFurnitureSequenceRequestMessage()
        {
        }
        
        
        public override void Serialize(IWriter writer)
        {
        }
        
        public override void Deserialize(IReader reader)
        {
        }
        
    }
    
}