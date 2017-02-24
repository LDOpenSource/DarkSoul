

// Generated on 02/23/2017 16:53:28
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameEntitiesDispositionMessage : NetworkMessage
    {
        public override ushort Id => 5696;
        
        
        public IEnumerable<Types.IdentifiedEntityDispositionInformations> dispositions;
        
        public GameEntitiesDispositionMessage()
        {
        }
        
        public GameEntitiesDispositionMessage(IEnumerable<Types.IdentifiedEntityDispositionInformations> dispositions)
        {
            this.dispositions = dispositions;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)dispositions.Count());
            foreach (var entry in dispositions)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            dispositions = new Types.IdentifiedEntityDispositionInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (dispositions as Types.IdentifiedEntityDispositionInformations[])[i] = new Types.IdentifiedEntityDispositionInformations();
                 (dispositions as Types.IdentifiedEntityDispositionInformations[])[i].Deserialize(reader);
            }
        }
        
    }
    
}