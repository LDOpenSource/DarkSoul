

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
    public class ObjectAveragePricesMessage : NetworkMessage
    {
        public override ushort Id => 6335;
        
        
        public IEnumerable<ushort> ids;
        public IEnumerable<double> avgPrices;
        
        public ObjectAveragePricesMessage()
        {
        }
        
        public ObjectAveragePricesMessage(IEnumerable<ushort> ids, IEnumerable<double> avgPrices)
        {
            this.ids = ids;
            this.avgPrices = avgPrices;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)ids.Count());
            foreach (var entry in ids)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteShort((short)avgPrices.Count());
            foreach (var entry in avgPrices)
            {
                 writer.WriteVarLong(entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            ids = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (ids as ushort[])[i] = reader.ReadVarUhShort();
            }
            limit = reader.ReadUShort();
            avgPrices = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 (avgPrices as double[])[i] = reader.ReadVarUhLong();
            }
        }
        
    }
    
}