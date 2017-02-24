

// Generated on 02/23/2017 18:06:42
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class JobCrafterDirectorySettings
    {
        public virtual short TypeId => 97;
        
        public sbyte jobId;
        public byte minLevel;
        public bool free;
        
        public JobCrafterDirectorySettings()
        {
        }
        
        public JobCrafterDirectorySettings(sbyte jobId, byte minLevel, bool free)
        {
            this.jobId = jobId;
            this.minLevel = minLevel;
            this.free = free;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteSByte(jobId);
            writer.WriteByte(minLevel);
            writer.WriteBoolean(free);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            jobId = reader.ReadSByte();
            minLevel = reader.ReadByte();
            free = reader.ReadBoolean();
        }
        
    }
    
}