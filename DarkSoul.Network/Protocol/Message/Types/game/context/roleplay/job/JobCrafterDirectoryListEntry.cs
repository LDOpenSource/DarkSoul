

// Generated on 02/23/2017 18:06:42
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class JobCrafterDirectoryListEntry
    {
        public virtual short TypeId => 196;
        
        public Types.JobCrafterDirectoryEntryPlayerInfo playerInfo;
        public Types.JobCrafterDirectoryEntryJobInfo jobInfo;
        
        public JobCrafterDirectoryListEntry()
        {
        }
        
        public JobCrafterDirectoryListEntry(Types.JobCrafterDirectoryEntryPlayerInfo playerInfo, Types.JobCrafterDirectoryEntryJobInfo jobInfo)
        {
            this.playerInfo = playerInfo;
            this.jobInfo = jobInfo;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            playerInfo.Serialize(writer);
            jobInfo.Serialize(writer);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            playerInfo = new Types.JobCrafterDirectoryEntryPlayerInfo();
            playerInfo.Deserialize(reader);
            jobInfo = new Types.JobCrafterDirectoryEntryJobInfo();
            jobInfo.Deserialize(reader);
        }
        
    }
    
}