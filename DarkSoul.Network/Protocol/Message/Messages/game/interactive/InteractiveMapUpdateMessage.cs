

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
    public class InteractiveMapUpdateMessage : NetworkMessage
    {
        public override ushort Id => 5002;
        
        
        public IEnumerable<Types.InteractiveElement> interactiveElements;
        
        public InteractiveMapUpdateMessage()
        {
        }
        
        public InteractiveMapUpdateMessage(IEnumerable<Types.InteractiveElement> interactiveElements)
        {
            this.interactiveElements = interactiveElements;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)interactiveElements.Count());
            foreach (var entry in interactiveElements)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            interactiveElements = new Types.InteractiveElement[limit];
            for (int i = 0; i < limit; i++)
            {
                 (interactiveElements as Types.InteractiveElement[])[i] = ProtocolTypeManager.GetInstance<Types.InteractiveElement>(reader.ReadUShort());
                 (interactiveElements as Types.InteractiveElement[])[i].Deserialize(reader);
            }
        }
        
    }
    
}