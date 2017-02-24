

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
    public class GameContextRemoveMultipleElementsMessage : NetworkMessage
    {
        public override ushort Id => 252;
        
        
        public IEnumerable<double> elementsIds;
        
        public GameContextRemoveMultipleElementsMessage()
        {
        }
        
        public GameContextRemoveMultipleElementsMessage(IEnumerable<double> elementsIds)
        {
            this.elementsIds = elementsIds;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)elementsIds.Count());
            foreach (var entry in elementsIds)
            {
                 writer.WriteDouble(entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            elementsIds = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 (elementsIds as double[])[i] = reader.ReadDouble();
            }
        }
        
    }
    
}