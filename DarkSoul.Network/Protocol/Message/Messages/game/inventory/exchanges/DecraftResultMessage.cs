

// Generated on 02/23/2017 16:53:51
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class DecraftResultMessage : NetworkMessage
    {
        public override ushort Id => 6569;
        
        
        public IEnumerable<Types.DecraftedItemStackInfo> results;
        
        public DecraftResultMessage()
        {
        }
        
        public DecraftResultMessage(IEnumerable<Types.DecraftedItemStackInfo> results)
        {
            this.results = results;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)results.Count());
            foreach (var entry in results)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            results = new Types.DecraftedItemStackInfo[limit];
            for (int i = 0; i < limit; i++)
            {
                 (results as Types.DecraftedItemStackInfo[])[i] = new Types.DecraftedItemStackInfo();
                 (results as Types.DecraftedItemStackInfo[])[i].Deserialize(reader);
            }
        }
        
    }
    
}