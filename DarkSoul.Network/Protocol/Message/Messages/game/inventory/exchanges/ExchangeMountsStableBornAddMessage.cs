

// Generated on 02/23/2017 16:53:53
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ExchangeMountsStableBornAddMessage : ExchangeMountsStableAddMessage
    {
        public override ushort Id => 6557;
        
        
        
        public ExchangeMountsStableBornAddMessage()
        {
        }
        
        public ExchangeMountsStableBornAddMessage(IEnumerable<Types.MountClientData> mountDescription)
         : base(mountDescription)
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