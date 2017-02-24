

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
    public class JobLevelUpMessage : NetworkMessage
    {
        public override ushort Id => 5656;
        
        
        public byte newLevel;
        public Types.JobDescription jobsDescription;
        
        public JobLevelUpMessage()
        {
        }
        
        public JobLevelUpMessage(byte newLevel, Types.JobDescription jobsDescription)
        {
            this.newLevel = newLevel;
            this.jobsDescription = jobsDescription;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteByte(newLevel);
            jobsDescription.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            newLevel = reader.ReadByte();
            jobsDescription = new Types.JobDescription();
            jobsDescription.Deserialize(reader);
        }
        
    }
    
}