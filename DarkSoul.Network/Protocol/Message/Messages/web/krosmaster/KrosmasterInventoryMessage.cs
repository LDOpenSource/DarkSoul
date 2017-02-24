

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
    public class KrosmasterInventoryMessage : NetworkMessage
    {
        public override ushort Id => 6350;
        
        
        public IEnumerable<Types.KrosmasterFigure> figures;
        
        public KrosmasterInventoryMessage()
        {
        }
        
        public KrosmasterInventoryMessage(IEnumerable<Types.KrosmasterFigure> figures)
        {
            this.figures = figures;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)figures.Count());
            foreach (var entry in figures)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            figures = new Types.KrosmasterFigure[limit];
            for (int i = 0; i < limit; i++)
            {
                 (figures as Types.KrosmasterFigure[])[i] = new Types.KrosmasterFigure();
                 (figures as Types.KrosmasterFigure[])[i].Deserialize(reader);
            }
        }
        
    }
    
}