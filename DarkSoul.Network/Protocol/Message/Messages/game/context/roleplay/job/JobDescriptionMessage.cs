

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
    public class JobDescriptionMessage : NetworkMessage
    {
        public override ushort Id => 5655;
        
        
        public IEnumerable<Types.JobDescription> jobsDescription;
        
        public JobDescriptionMessage()
        {
        }
        
        public JobDescriptionMessage(IEnumerable<Types.JobDescription> jobsDescription)
        {
            this.jobsDescription = jobsDescription;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)jobsDescription.Count());
            foreach (var entry in jobsDescription)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            jobsDescription = new Types.JobDescription[limit];
            for (int i = 0; i < limit; i++)
            {
                 (jobsDescription as Types.JobDescription[])[i] = new Types.JobDescription();
                 (jobsDescription as Types.JobDescription[])[i].Deserialize(reader);
            }
        }
        
    }
    
}