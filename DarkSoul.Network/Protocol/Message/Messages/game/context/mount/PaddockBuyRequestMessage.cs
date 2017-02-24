

// Generated on 02/23/2017 16:53:33
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class PaddockBuyRequestMessage : NetworkMessage
    {
        public override ushort Id => 5951;
        
        
        public double proposedPrice;
        
        public PaddockBuyRequestMessage()
        {
        }
        
        public PaddockBuyRequestMessage(double proposedPrice)
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