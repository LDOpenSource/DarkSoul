

// Generated on 02/23/2017 16:53:53
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ExchangeCraftResultMessage : NetworkMessage
    {
        public override ushort Id => 5790;
        
        
        public sbyte craftResult;
        
        public ExchangeCraftResultMessage()
        {
        }
        
        public ExchangeCraftResultMessage(sbyte craftResult)
        {
            this.craftResult = craftResult;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(craftResult);
        }
        
        public override void Deserialize(IReader reader)
        {
            craftResult = reader.ReadSByte();
        }
        
    }
    
}