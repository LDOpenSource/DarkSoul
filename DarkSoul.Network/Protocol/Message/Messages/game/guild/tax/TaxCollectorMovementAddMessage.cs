

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
    public class TaxCollectorMovementAddMessage : NetworkMessage
    {
        public override ushort Id => 5917;
        
        
        public Types.TaxCollectorInformations informations;
        
        public TaxCollectorMovementAddMessage()
        {
        }
        
        public TaxCollectorMovementAddMessage(Types.TaxCollectorInformations informations)
        {
            this.informations = informations;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort(informations.TypeId);
            informations.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            informations = ProtocolTypeManager.GetInstance<Types.TaxCollectorInformations>(reader.ReadUShort());
            informations.Deserialize(reader);
        }
        
    }
    
}