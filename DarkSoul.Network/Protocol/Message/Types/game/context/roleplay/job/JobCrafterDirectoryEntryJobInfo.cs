

// Generated on 02/23/2017 18:06:42
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class JobCrafterDirectoryEntryJobInfo
    {
        public virtual short TypeId => 195;
        
        public sbyte jobId;
        public byte jobLevel;
        public bool free;
        public byte minLevel;
        
        public JobCrafterDirectoryEntryJobInfo()
        {
        }
        
        public JobCrafterDirectoryEntryJobInfo(sbyte jobId, byte jobLevel, bool free, byte minLevel)
        {
            this.jobId = jobId;
            this.jobLevel = jobLevel;
            this.free = free;
            this.minLevel = minLevel;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteSByte(jobId);
            writer.WriteByte(jobLevel);
            writer.WriteBoolean(free);
            writer.WriteByte(minLevel);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            jobId = reader.ReadSByte();
            jobLevel = reader.ReadByte();
            free = reader.ReadBoolean();
            minLevel = reader.ReadByte();
        }
        
    }
    
}