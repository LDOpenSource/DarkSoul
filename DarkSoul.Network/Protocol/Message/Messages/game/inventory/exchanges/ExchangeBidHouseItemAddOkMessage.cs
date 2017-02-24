

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
    public class ExchangeBidHouseItemAddOkMessage : NetworkMessage
    {
        public override ushort Id => 5945;
        
        
        public Types.ObjectItemToSellInBid itemInfo;
        
        public ExchangeBidHouseItemAddOkMessage()
        {
        }
        
        public ExchangeBidHouseItemAddOkMessage(Types.ObjectItemToSellInBid itemInfo)
        {
            this.itemInfo = itemInfo;
        }
        
        public override void Serialize(IWriter writer)
        {
            itemInfo.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            itemInfo = new Types.ObjectItemToSellInBid();
            itemInfo.Deserialize(reader);
        }
        
    }
    
}