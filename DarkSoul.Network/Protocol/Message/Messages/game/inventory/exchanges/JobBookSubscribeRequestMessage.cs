

// Generated on 02/23/2017 16:53:57
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class JobBookSubscribeRequestMessage : NetworkMessage
    {
        public override ushort Id => 6592;
        
        
        public IEnumerable<sbyte> jobIds;
        
        public JobBookSubscribeRequestMessage()
        {
        }
        
        public JobBookSubscribeRequestMessage(IEnumerable<sbyte> jobIds)
        {
            this.jobIds = jobIds;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)jobIds.Count());
            foreach (var entry in jobIds)
            {
                 writer.WriteSByte(entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            jobIds = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 (jobIds as sbyte[])[i] = reader.ReadSByte();
            }
        }
        
    }
    
}