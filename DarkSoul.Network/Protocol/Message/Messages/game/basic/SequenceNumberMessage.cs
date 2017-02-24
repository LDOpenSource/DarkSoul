

// Generated on 02/23/2017 16:53:24
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class SequenceNumberMessage : NetworkMessage
    {
        public override ushort Id => 6317;
        
        
        public ushort number;
        
        public SequenceNumberMessage()
        {
        }
        
        public SequenceNumberMessage(ushort number)
        {
            this.number = number;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteUShort(number);
        }
        
        public override void Deserialize(IReader reader)
        {
            number = reader.ReadUShort();
        }
        
    }
    
}