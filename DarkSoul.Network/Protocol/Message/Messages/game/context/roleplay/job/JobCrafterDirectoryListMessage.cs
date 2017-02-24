

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
    public class JobCrafterDirectoryListMessage : NetworkMessage
    {
        public override ushort Id => 6046;
        
        
        public IEnumerable<Types.JobCrafterDirectoryListEntry> listEntries;
        
        public JobCrafterDirectoryListMessage()
        {
        }
        
        public JobCrafterDirectoryListMessage(IEnumerable<Types.JobCrafterDirectoryListEntry> listEntries)
        {
            this.listEntries = listEntries;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)listEntries.Count());
            foreach (var entry in listEntries)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            listEntries = new Types.JobCrafterDirectoryListEntry[limit];
            for (int i = 0; i < limit; i++)
            {
                 (listEntries as Types.JobCrafterDirectoryListEntry[])[i] = new Types.JobCrafterDirectoryListEntry();
                 (listEntries as Types.JobCrafterDirectoryListEntry[])[i].Deserialize(reader);
            }
        }
        
    }
    
}