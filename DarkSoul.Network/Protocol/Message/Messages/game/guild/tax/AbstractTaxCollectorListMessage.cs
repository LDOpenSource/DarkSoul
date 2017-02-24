

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
    public class AbstractTaxCollectorListMessage : NetworkMessage
    {
        public override ushort Id => 6568;
        
        
        public IEnumerable<Types.TaxCollectorInformations> informations;
        
        public AbstractTaxCollectorListMessage()
        {
        }
        
        public AbstractTaxCollectorListMessage(IEnumerable<Types.TaxCollectorInformations> informations)
        {
            this.informations = informations;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)informations.Count());
            foreach (var entry in informations)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            informations = new Types.TaxCollectorInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (informations as Types.TaxCollectorInformations[])[i] = ProtocolTypeManager.GetInstance<Types.TaxCollectorInformations>(reader.ReadUShort());
                 (informations as Types.TaxCollectorInformations[])[i].Deserialize(reader);
            }
        }
        
    }
    
}