

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
    public class ExchangeBidHouseGenericItemAddedMessage : NetworkMessage
    {
        public override ushort Id => 5947;
        
        
        public ushort objGenericId;
        
        public ExchangeBidHouseGenericItemAddedMessage()
        {
        }
        
        public ExchangeBidHouseGenericItemAddedMessage(ushort objGenericId)
        {
            this.objGenericId = objGenericId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)objGenericId);
        }
        
        public override void Deserialize(IReader reader)
        {
            objGenericId = reader.ReadVarUhShort();
        }
        
    }
    
}