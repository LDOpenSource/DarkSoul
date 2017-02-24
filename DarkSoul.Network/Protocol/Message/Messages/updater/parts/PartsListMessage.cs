

// Generated on 02/23/2017 16:54:05
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class PartsListMessage : NetworkMessage
    {
        public override ushort Id => 1502;
        
        
        public IEnumerable<Types.ContentPart> parts;
        
        public PartsListMessage()
        {
        }
        
        public PartsListMessage(IEnumerable<Types.ContentPart> parts)
        {
            this.parts = parts;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)parts.Count());
            foreach (var entry in parts)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            parts = new Types.ContentPart[limit];
            for (int i = 0; i < limit; i++)
            {
                 (parts as Types.ContentPart[])[i] = new Types.ContentPart();
                 (parts as Types.ContentPart[])[i].Deserialize(reader);
            }
        }
        
    }
    
}