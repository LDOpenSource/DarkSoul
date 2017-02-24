

// Generated on 02/23/2017 16:53:15
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class BasicStatWithDataMessage : BasicStatMessage
    {
        public override ushort Id => 6573;
        
        
        public IEnumerable<Types.StatisticData> datas;
        
        public BasicStatWithDataMessage()
        {
        }
        
        public BasicStatWithDataMessage(double timeSpent, ushort statId, IEnumerable<Types.StatisticData> datas)
         : base(timeSpent, statId)
        {
            this.datas = datas;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort((short)datas.Count());
            foreach (var entry in datas)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            var limit = reader.ReadUShort();
            datas = new Types.StatisticData[limit];
            for (int i = 0; i < limit; i++)
            {
                 (datas as Types.StatisticData[])[i] = ProtocolTypeManager.GetInstance<Types.StatisticData>(reader.ReadUShort());
                 (datas as Types.StatisticData[])[i].Deserialize(reader);
            }
        }
        
    }
    
}