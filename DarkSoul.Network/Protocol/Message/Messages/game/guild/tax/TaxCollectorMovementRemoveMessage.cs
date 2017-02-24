

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
    public class TaxCollectorMovementRemoveMessage : NetworkMessage
    {
        public override ushort Id => 5915;
        
        
        public int collectorId;
        
        public TaxCollectorMovementRemoveMessage()
        {
        }
        
        public TaxCollectorMovementRemoveMessage(int collectorId)
        {
            this.collectorId = collectorId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteInt(collectorId);
        }
        
        public override void Deserialize(IReader reader)
        {
            collectorId = reader.ReadInt();
        }
        
    }
    
}