

// Generated on 02/23/2017 16:53:15
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class AggregateStatMessage : NetworkMessage
    {
        public override ushort Id => 6669;
        
        
        public ushort statId;
        
        public AggregateStatMessage()
        {
        }
        
        public AggregateStatMessage(ushort statId)
        {
            this.statId = statId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)statId);
        }
        
        public override void Deserialize(IReader reader)
        {
            statId = reader.ReadVarUhShort();
        }
        
    }
    
}