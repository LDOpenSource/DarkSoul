

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
    public class JobCrafterDirectoryEntryMessage : NetworkMessage
    {
        public override ushort Id => 6044;
        
        
        public Types.JobCrafterDirectoryEntryPlayerInfo playerInfo;
        public IEnumerable<Types.JobCrafterDirectoryEntryJobInfo> jobInfoList;
        public Types.EntityLook playerLook;
        
        public JobCrafterDirectoryEntryMessage()
        {
        }
        
        public JobCrafterDirectoryEntryMessage(Types.JobCrafterDirectoryEntryPlayerInfo playerInfo, IEnumerable<Types.JobCrafterDirectoryEntryJobInfo> jobInfoList, Types.EntityLook playerLook)
        {
            this.playerInfo = playerInfo;
            this.jobInfoList = jobInfoList;
            this.playerLook = playerLook;
        }
        
        public override void Serialize(IWriter writer)
        {
            playerInfo.Serialize(writer);
            writer.WriteShort((short)jobInfoList.Count());
            foreach (var entry in jobInfoList)
            {
                 entry.Serialize(writer);
            }
            playerLook.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            playerInfo = new Types.JobCrafterDirectoryEntryPlayerInfo();
            playerInfo.Deserialize(reader);
            var limit = reader.ReadUShort();
            jobInfoList = new Types.JobCrafterDirectoryEntryJobInfo[limit];
            for (int i = 0; i < limit; i++)
            {
                 (jobInfoList as Types.JobCrafterDirectoryEntryJobInfo[])[i] = new Types.JobCrafterDirectoryEntryJobInfo();
                 (jobInfoList as Types.JobCrafterDirectoryEntryJobInfo[])[i].Deserialize(reader);
            }
            playerLook = new Types.EntityLook();
            playerLook.Deserialize(reader);
        }
        
    }
    
}