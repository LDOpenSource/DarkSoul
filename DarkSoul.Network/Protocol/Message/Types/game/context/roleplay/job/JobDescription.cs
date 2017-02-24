

// Generated on 02/23/2017 18:06:42
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class JobDescription
    {
        public virtual short TypeId => 101;
        
        public sbyte jobId;
        public IEnumerable<Types.SkillActionDescription> skills;
        
        public JobDescription()
        {
        }
        
        public JobDescription(sbyte jobId, IEnumerable<Types.SkillActionDescription> skills)
        {
            this.jobId = jobId;
            this.skills = skills;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteSByte(jobId);
            writer.WriteShort((short)skills.Count());
            foreach (var entry in skills)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
        }
        
        public virtual void Deserialize(IReader reader)
        {
            jobId = reader.ReadSByte();
            var limit = reader.ReadUShort();
            skills = new Types.SkillActionDescription[limit];
            for (int i = 0; i < limit; i++)
            {
                 (skills as Types.SkillActionDescription[])[i] = ProtocolTypeManager.GetInstance<Types.SkillActionDescription>(reader.ReadUShort());
                 (skills as Types.SkillActionDescription[])[i].Deserialize(reader);
            }
        }
        
    }
    
}