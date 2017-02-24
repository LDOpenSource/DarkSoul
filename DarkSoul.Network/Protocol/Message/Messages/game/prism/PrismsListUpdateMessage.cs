

// Generated on 02/23/2017 16:54:02
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class PrismsListUpdateMessage : PrismsListMessage
    {
        public override ushort Id => 6438;
        
        
        
        public PrismsListUpdateMessage()
        {
        }
        
        public PrismsListUpdateMessage(IEnumerable<Types.PrismSubareaEmptyInfo> prisms)
         : base(prisms)
        {
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
        }
        
    }
    
}