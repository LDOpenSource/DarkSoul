

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
    public class HouseSellFromInsideRequestMessage : HouseSellRequestMessage
    {
        public override ushort Id => 5884;
        
        
        
        public HouseSellFromInsideRequestMessage()
        {
        }
        
        public HouseSellFromInsideRequestMessage(uint instanceId, double amount, bool forSale)
         : base(instanceId, amount, forSale)
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