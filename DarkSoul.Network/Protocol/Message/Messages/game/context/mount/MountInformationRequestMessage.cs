

// Generated on 02/23/2017 16:53:32
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class MountInformationRequestMessage : NetworkMessage
    {
        public override ushort Id => 5972;
        
        
        public double id;
        public double time;
        
        public MountInformationRequestMessage()
        {
        }
        
        public MountInformationRequestMessage(double id, double time)
        {
            this.id = id;
            this.time = time;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteDouble(id);
            writer.WriteDouble(time);
        }
        
        public override void Deserialize(IReader reader)
        {
            id = reader.ReadDouble();
            time = reader.ReadDouble();
        }
        
    }
    
}