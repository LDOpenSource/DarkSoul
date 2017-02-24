

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
    public class ExchangeBidHouseInListUpdatedMessage : ExchangeBidHouseInListAddedMessage
    {
        public override ushort Id => 6337;
        
        
        
        public ExchangeBidHouseInListUpdatedMessage()
        {
        }
        
        public ExchangeBidHouseInListUpdatedMessage(int itemUID, int objGenericId, IEnumerable<Types.ObjectEffect> effects, IEnumerable<double> prices)
         : base(itemUID, objGenericId, effects, prices)
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