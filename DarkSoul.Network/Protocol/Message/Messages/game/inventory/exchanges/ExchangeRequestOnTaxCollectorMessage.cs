

// Generated on 02/23/2017 16:53:55
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ExchangeRequestOnTaxCollectorMessage : NetworkMessage
    {
        public override ushort Id => 5779;
        
        
        public int taxCollectorId;
        
        public ExchangeRequestOnTaxCollectorMessage()
        {
        }
        
        public ExchangeRequestOnTaxCollectorMessage(int taxCollectorId)
        {
            this.taxCollectorId = taxCollectorId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteInt(taxCollectorId);
        }
        
        public override void Deserialize(IReader reader)
        {
            taxCollectorId = reader.ReadInt();
        }
        
    }
    
}