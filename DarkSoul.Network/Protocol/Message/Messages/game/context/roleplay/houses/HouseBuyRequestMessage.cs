

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
    public class HouseBuyRequestMessage : NetworkMessage
    {
        public override ushort Id => 5738;
        
        
        public double proposedPrice;
        
        public HouseBuyRequestMessage()
        {
        }
        
        public HouseBuyRequestMessage(double proposedPrice)
        {
            this.proposedPrice = proposedPrice;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarLong(proposedPrice);
        }
        
        public override void Deserialize(IReader reader)
        {
            proposedPrice = reader.ReadVarUhLong();
        }
        
    }
    
}