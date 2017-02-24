

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
    public class ExchangeErrorMessage : NetworkMessage
    {
        public override ushort Id => 5513;
        
        
        public sbyte errorType;
        
        public ExchangeErrorMessage()
        {
        }
        
        public ExchangeErrorMessage(sbyte errorType)
        {
            this.errorType = errorType;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(errorType);
        }
        
        public override void Deserialize(IReader reader)
        {
            errorType = reader.ReadSByte();
        }
        
    }
    
}