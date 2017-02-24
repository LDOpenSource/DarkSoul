

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
    public class JobExperienceUpdateMessage : NetworkMessage
    {
        public override ushort Id => 0x1616;
        
        
        public Types.JobExperience experiencesUpdate;
        
        public JobExperienceUpdateMessage()
        {
        }
        
        public JobExperienceUpdateMessage(Types.JobExperience experiencesUpdate)
        {
            this.experiencesUpdate = experiencesUpdate;
        }
        
        public override void Serialize(IWriter writer)
        {
            experiencesUpdate.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            experiencesUpdate = new Types.JobExperience();
            experiencesUpdate.Deserialize(reader);
        }
        
    }
    
}