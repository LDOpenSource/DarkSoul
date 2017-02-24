

// Generated on 02/23/2017 16:53:51
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class StatedMapUpdateMessage : NetworkMessage
    {
        public override ushort Id => 5716;
        
        
        public IEnumerable<Types.StatedElement> statedElements;
        
        public StatedMapUpdateMessage()
        {
        }
        
        public StatedMapUpdateMessage(IEnumerable<Types.StatedElement> statedElements)
        {
            this.statedElements = statedElements;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)statedElements.Count());
            foreach (var entry in statedElements)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            statedElements = new Types.StatedElement[limit];
            for (int i = 0; i < limit; i++)
            {
                 (statedElements as Types.StatedElement[])[i] = new Types.StatedElement();
                 (statedElements as Types.StatedElement[])[i].Deserialize(reader);
            }
        }
        
    }
    
}