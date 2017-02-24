

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
    public class ExchangeBidHouseInListRemovedMessage : NetworkMessage
    {
        public override ushort Id => 5950;
        
        
        public int itemUID;
        
        public ExchangeBidHouseInListRemovedMessage()
        {
        }
        
        public ExchangeBidHouseInListRemovedMessage(int itemUID)
        {
            this.itemUID = itemUID;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteInt(itemUID);
        }
        
        public override void Deserialize(IReader reader)
        {
            itemUID = reader.ReadInt();
        }
        
    }
    
}