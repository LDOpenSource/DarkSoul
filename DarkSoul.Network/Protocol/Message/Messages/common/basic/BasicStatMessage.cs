

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
    public class BasicStatMessage : NetworkMessage
    {
        public override ushort Id => 6530;
        
        
        public double timeSpent;
        public ushort statId;
        
        public BasicStatMessage()
        {
        }
        
        public BasicStatMessage(double timeSpent, ushort statId)
        {
            this.timeSpent = timeSpent;
            this.statId = statId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteDouble(timeSpent);
            writer.WriteVarShort((int)statId);
        }
        
        public override void Deserialize(IReader reader)
        {
            timeSpent = reader.ReadDouble();
            statId = reader.ReadVarUhShort();
        }
        
    }
    
}