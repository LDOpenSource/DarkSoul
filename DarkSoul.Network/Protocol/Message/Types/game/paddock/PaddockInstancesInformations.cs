

// Generated on 02/23/2017 18:06:46
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class PaddockInstancesInformations : PaddockInformations
    {
        public override short TypeId => 509;
        
        public IEnumerable<Types.PaddockBuyableInformations> paddocks;
        
        public PaddockInstancesInformations()
        {
        }
        
        public PaddockInstancesInformations(ushort maxOutdoorMount, ushort maxItems, IEnumerable<Types.PaddockBuyableInformations> paddocks)
         : base(maxOutdoorMount, maxItems)
        {
            this.paddocks = paddocks;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort((short)paddocks.Count());
            foreach (var entry in paddocks)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            var limit = reader.ReadUShort();
            paddocks = new Types.PaddockBuyableInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (paddocks as Types.PaddockBuyableInformations[])[i] = ProtocolTypeManager.GetInstance<Types.PaddockBuyableInformations>(reader.ReadUShort());
                 (paddocks as Types.PaddockBuyableInformations[])[i].Deserialize(reader);
            }
        }
        
    }
    
}