

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
    public class GameContextRemoveMultipleElementsWithEventsMessage : GameContextRemoveMultipleElementsMessage
    {
        public override ushort Id => 6416;
        
        
        public IEnumerable<sbyte> elementEventIds;
        
        public GameContextRemoveMultipleElementsWithEventsMessage()
        {
        }
        
        public GameContextRemoveMultipleElementsWithEventsMessage(IEnumerable<double> elementsIds, IEnumerable<sbyte> elementEventIds)
         : base(elementsIds)
        {
            this.elementEventIds = elementEventIds;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort((short)elementEventIds.Count());
            foreach (var entry in elementEventIds)
            {
                 writer.WriteSByte(entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            var limit = reader.ReadUShort();
            elementEventIds = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 (elementEventIds as sbyte[])[i] = reader.ReadSByte();
            }
        }
        
    }
    
}