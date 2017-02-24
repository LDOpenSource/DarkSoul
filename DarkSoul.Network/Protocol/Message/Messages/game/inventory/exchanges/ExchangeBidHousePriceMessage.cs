

// Generated on 02/23/2017 16:53:52
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ExchangeBidHousePriceMessage : NetworkMessage
    {
        public override ushort Id => 5805;
        
        
        public ushort genId;
        
        public ExchangeBidHousePriceMessage()
        {
        }
        
        public ExchangeBidHousePriceMessage(ushort genId)
        {
            this.genId = genId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)genId);
        }
        
        public override void Deserialize(IReader reader)
        {
            genId = reader.ReadVarUhShort();
        }
        
    }
    
}