

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
    public class ExchangeCraftCountModifiedMessage : NetworkMessage
    {
        public override ushort Id => 6595;
        
        
        public int count;
        
        public ExchangeCraftCountModifiedMessage()
        {
        }
        
        public ExchangeCraftCountModifiedMessage(int count)
        {
            this.count = count;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)count);
        }
        
        public override void Deserialize(IReader reader)
        {
            count = reader.ReadVarInt();
        }
        
    }
    
}