

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
    public class ExchangeBidHouseTypeMessage : NetworkMessage
    {
        public override ushort Id => 5803;
        
        
        public uint type;
        
        public ExchangeBidHouseTypeMessage()
        {
        }
        
        public ExchangeBidHouseTypeMessage(uint type)
        {
            this.type = type;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)type);
        }
        
        public override void Deserialize(IReader reader)
        {
            type = reader.ReadVarUhInt();
        }
        
    }
    
}