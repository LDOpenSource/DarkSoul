

// Generated on 02/23/2017 18:06:37
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class StatisticDataBoolean : StatisticData
    {
        public override short TypeId => 482;
        
        public bool value;
        
        public StatisticDataBoolean()
        {
        }
        
        public StatisticDataBoolean(bool value)
        {
            this.value = value;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteBoolean(value);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            value = reader.ReadBoolean();
        }
        
    }
    
}