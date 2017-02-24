

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
    public class ExchangeShopStockMovementUpdatedMessage : NetworkMessage
    {
        public override ushort Id => 5909;
        
        
        public Types.ObjectItemToSell objectInfo;
        
        public ExchangeShopStockMovementUpdatedMessage()
        {
        }
        
        public ExchangeShopStockMovementUpdatedMessage(Types.ObjectItemToSell objectInfo)
        {
            this.objectInfo = objectInfo;
        }
        
        public override void Serialize(IWriter writer)
        {
            objectInfo.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            objectInfo = new Types.ObjectItemToSell();
            objectInfo.Deserialize(reader);
        }
        
    }
    
}