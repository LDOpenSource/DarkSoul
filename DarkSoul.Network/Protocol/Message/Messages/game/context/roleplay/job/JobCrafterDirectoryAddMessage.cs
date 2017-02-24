

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
    public class JobCrafterDirectoryAddMessage : NetworkMessage
    {
        public override ushort Id => 5651;
        
        
        public Types.JobCrafterDirectoryListEntry listEntry;
        
        public JobCrafterDirectoryAddMessage()
        {
        }
        
        public JobCrafterDirectoryAddMessage(Types.JobCrafterDirectoryListEntry listEntry)
        {
            this.listEntry = listEntry;
        }
        
        public override void Serialize(IWriter writer)
        {
            listEntry.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            listEntry = new Types.JobCrafterDirectoryListEntry();
            listEntry.Deserialize(reader);
        }
        
    }
    
}