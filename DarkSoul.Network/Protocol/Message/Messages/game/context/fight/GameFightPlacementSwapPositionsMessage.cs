

// Generated on 02/23/2017 16:53:30
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameFightPlacementSwapPositionsMessage : NetworkMessage
    {
        public override ushort Id => 6544;
        
        
        public IEnumerable<Types.IdentifiedEntityDispositionInformations> dispositions;
        
        public GameFightPlacementSwapPositionsMessage()
        {
        }
        
        public GameFightPlacementSwapPositionsMessage(IEnumerable<Types.IdentifiedEntityDispositionInformations> dispositions)
        {
            this.dispositions = dispositions;
        }
        
        public override void Serialize(IWriter writer)
        {
            foreach (var entry in dispositions)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            dispositions = new Types.IdentifiedEntityDispositionInformations[2];
            for (int i = 0; i < 2; i++)
            {
                 (dispositions as Types.IdentifiedEntityDispositionInformations[])[i] = new Types.IdentifiedEntityDispositionInformations();
                 (dispositions as Types.IdentifiedEntityDispositionInformations[])[i].Deserialize(reader);
            }
        }
        
    }
    
}