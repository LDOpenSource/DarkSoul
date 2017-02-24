

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
    public class TaxCollectorMovementsOfflineMessage : NetworkMessage
    {
        public override ushort Id => 6611;
        
        
        public IEnumerable<Types.TaxCollectorMovement> movements;
        
        public TaxCollectorMovementsOfflineMessage()
        {
        }
        
        public TaxCollectorMovementsOfflineMessage(IEnumerable<Types.TaxCollectorMovement> movements)
        {
            this.movements = movements;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)movements.Count());
            foreach (var entry in movements)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            movements = new Types.TaxCollectorMovement[limit];
            for (int i = 0; i < limit; i++)
            {
                 (movements as Types.TaxCollectorMovement[])[i] = new Types.TaxCollectorMovement();
                 (movements as Types.TaxCollectorMovement[])[i].Deserialize(reader);
            }
        }
        
    }
    
}