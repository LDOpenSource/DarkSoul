

// Generated on 02/23/2017 16:53:58
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ObjectJobAddedMessage : NetworkMessage
    {
        public override ushort Id => 6014;
        
        
        public sbyte jobId;
        
        public ObjectJobAddedMessage()
        {
        }
        
        public ObjectJobAddedMessage(sbyte jobId)
        {
            this.jobId = jobId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(jobId);
        }
        
        public override void Deserialize(IReader reader)
        {
            jobId = reader.ReadSByte();
        }
        
    }
    
}