

// Generated on 02/23/2017 16:53:56
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ExchangeStartOkJobIndexMessage : NetworkMessage
    {
        public override ushort Id => 5819;
        
        
        public IEnumerable<uint> jobs;
        
        public ExchangeStartOkJobIndexMessage()
        {
        }
        
        public ExchangeStartOkJobIndexMessage(IEnumerable<uint> jobs)
        {
            this.jobs = jobs;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)jobs.Count());
            foreach (var entry in jobs)
            {
                 writer.WriteVarInt((int)entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            jobs = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 (jobs as uint[])[i] = reader.ReadVarUhInt();
            }
        }
        
    }
    
}