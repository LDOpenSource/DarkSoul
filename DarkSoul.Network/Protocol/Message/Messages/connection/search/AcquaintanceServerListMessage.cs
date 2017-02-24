

// Generated on 02/23/2017 16:53:17
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class AcquaintanceServerListMessage : NetworkMessage
    {
        public override ushort Id => 6142;
        
        
        public IEnumerable<ushort> servers;
        
        public AcquaintanceServerListMessage()
        {
        }
        
        public AcquaintanceServerListMessage(IEnumerable<ushort> servers)
        {
            this.servers = servers;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)servers.Count());
            foreach (var entry in servers)
            {
                 writer.WriteVarShort((int)entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            servers = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (servers as ushort[])[i] = reader.ReadVarUhShort();
            }
        }
        
    }
    
}