

// Generated on 02/23/2017 16:53:50
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class TopTaxCollectorListMessage : AbstractTaxCollectorListMessage
    {
        public override ushort Id => 6565;
        
        
        public bool isDungeon;
        
        public TopTaxCollectorListMessage()
        {
        }
        
        public TopTaxCollectorListMessage(IEnumerable<Types.TaxCollectorInformations> informations, bool isDungeon)
         : base(informations)
        {
            this.isDungeon = isDungeon;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteBoolean(isDungeon);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            isDungeon = reader.ReadBoolean();
        }
        
    }
    
}