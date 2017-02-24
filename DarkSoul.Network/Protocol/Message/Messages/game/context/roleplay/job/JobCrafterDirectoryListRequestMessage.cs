

// Generated on 02/23/2017 16:53:38
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class JobCrafterDirectoryListRequestMessage : NetworkMessage
    {
        public override ushort Id => 6047;
        
        
        public sbyte jobId;
        
        public JobCrafterDirectoryListRequestMessage()
        {
        }
        
        public JobCrafterDirectoryListRequestMessage(sbyte jobId)
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