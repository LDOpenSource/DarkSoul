

// Generated on 02/23/2017 16:53:51
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ObjectAveragePricesErrorMessage : NetworkMessage
    {
        public override ushort Id => 6336;
        
        
        
        public ObjectAveragePricesErrorMessage()
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