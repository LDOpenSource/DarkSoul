

// Generated on 02/23/2017 16:53:31
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameFightTurnListMessage : NetworkMessage
    {
        public override ushort Id => 713;
        
        
        public IEnumerable<double> ids;
        public IEnumerable<double> deadsIds;
        
        public GameFightTurnListMessage()
        {
        }
        
        public GameFightTurnListMessage(IEnumerable<double> ids, IEnumerable<double> deadsIds)
        {
            this.ids = ids;
            this.deadsIds = deadsIds;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)ids.Count());
            foreach (var entry in ids)
            {
                 writer.WriteDouble(entry);
            }
            writer.WriteShort((short)deadsIds.Count());
            foreach (var entry in deadsIds)
            {
                 writer.WriteDouble(entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            ids = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 (ids as double[])[i] = reader.ReadDouble();
            }
            limit = reader.ReadUShort();
            deadsIds = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 (deadsIds as double[])[i] = reader.ReadDouble();
            }
        }
        
    }
    
}