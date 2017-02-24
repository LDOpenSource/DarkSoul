

// Generated on 02/23/2017 16:53:49
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class TaxCollectorListMessage : AbstractTaxCollectorListMessage
    {
        public override ushort Id => 5930;
        
        
        public sbyte nbcollectorMax;
        public IEnumerable<Types.TaxCollectorFightersInformation> fightersInformations;
        
        public TaxCollectorListMessage()
        {
        }
        
        public TaxCollectorListMessage(IEnumerable<Types.TaxCollectorInformations> informations, sbyte nbcollectorMax, IEnumerable<Types.TaxCollectorFightersInformation> fightersInformations)
         : base(informations)
        {
            this.nbcollectorMax = nbcollectorMax;
            this.fightersInformations = fightersInformations;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSByte(nbcollectorMax);
            writer.WriteShort((short)fightersInformations.Count());
            foreach (var entry in fightersInformations)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            nbcollectorMax = reader.ReadSByte();
            var limit = reader.ReadUShort();
            fightersInformations = new Types.TaxCollectorFightersInformation[limit];
            for (int i = 0; i < limit; i++)
            {
                 (fightersInformations as Types.TaxCollectorFightersInformation[])[i] = new Types.TaxCollectorFightersInformation();
                 (fightersInformations as Types.TaxCollectorFightersInformation[])[i].Deserialize(reader);
            }
        }
        
    }
    
}