

// Generated on 02/23/2017 16:53:45
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class DareWonMessage : NetworkMessage
    {
        public override ushort Id => 6681;
        
        
        public double dareId;
        
        public DareWonMessage()
        {
        }
        
        public DareWonMessage(double dareId)
        {
            this.dareId = dareId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteDouble(dareId);
        }
        
        public override void Deserialize(IReader reader)
        {
            dareId = reader.ReadDouble();
        }
        
    }
    
}