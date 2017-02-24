

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
    public class ExchangeBidHouseListMessage : NetworkMessage
    {
        public override ushort Id => 5807;
        
        
        public ushort id;
        
        public ExchangeBidHouseListMessage()
        {
        }
        
        public ExchangeBidHouseListMessage(ushort id)
        {
            this.id = id;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)id);
        }
        
        public override void Deserialize(IReader reader)
        {
            id = reader.ReadVarUhShort();
        }
        
    }
    
}