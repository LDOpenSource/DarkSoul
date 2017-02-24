

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
    public class JobExperienceMultiUpdateMessage : NetworkMessage
    {
        public override ushort Id => 5809;
        
        
        public IEnumerable<Types.JobExperience> experiencesUpdate;
        
        public JobExperienceMultiUpdateMessage()
        {
        }
        
        public JobExperienceMultiUpdateMessage(IEnumerable<Types.JobExperience> experiencesUpdate)
        {
            this.experiencesUpdate = experiencesUpdate;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)experiencesUpdate.Count());
            foreach (var entry in experiencesUpdate)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            experiencesUpdate = new Types.JobExperience[limit];
            for (int i = 0; i < limit; i++)
            {
                 (experiencesUpdate as Types.JobExperience[])[i] = new Types.JobExperience();
                 (experiencesUpdate as Types.JobExperience[])[i].Deserialize(reader);
            }
        }
        
    }
    
}