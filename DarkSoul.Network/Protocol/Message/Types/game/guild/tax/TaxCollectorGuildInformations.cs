

// Generated on 02/23/2017 18:06:45
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class TaxCollectorGuildInformations : TaxCollectorComplementaryInformations
    {
        public override short TypeId => 446;
        
        public Types.BasicGuildInformations guild;
        
        public TaxCollectorGuildInformations()
        {
        }
        
        public TaxCollectorGuildInformations(Types.BasicGuildInformations guild)
        {
            this.guild = guild;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            guild.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            guild = new Types.BasicGuildInformations();
            guild.Deserialize(reader);
        }
        
    }
    
}