

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
    public class ExchangeBidHouseItemRemoveOkMessage : NetworkMessage
    {
        public override ushort Id => 5946;
        
        
        public int sellerId;
        
        public ExchangeBidHouseItemRemoveOkMessage()
        {
        }
        
        public ExchangeBidHouseItemRemoveOkMessage(int sellerId)
        {
            this.sellerId = sellerId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteInt(sellerId);
        }
        
        public override void Deserialize(IReader reader)
        {
            sellerId = reader.ReadInt();
        }
        
    }
    
}