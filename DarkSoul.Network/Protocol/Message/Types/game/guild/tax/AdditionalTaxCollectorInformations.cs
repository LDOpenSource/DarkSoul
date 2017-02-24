

// Generated on 02/23/2017 18:06:45
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class AdditionalTaxCollectorInformations
    {
        public virtual short TypeId => 165;
        
        public string collectorCallerName;
        public int date;
        
        public AdditionalTaxCollectorInformations()
        {
        }
        
        public AdditionalTaxCollectorInformations(string collectorCallerName, int date)
        {
            this.collectorCallerName = collectorCallerName;
            this.date = date;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteUTF(collectorCallerName);
            writer.WriteInt(date);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            collectorCallerName = reader.ReadUTF();
            date = reader.ReadInt();
        }
        
    }
    
}