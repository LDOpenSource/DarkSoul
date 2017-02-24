

// Generated on 02/23/2017 16:53:45
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class DareVersatileListMessage : NetworkMessage
    {
        public override ushort Id => 6657;
        
        
        public IEnumerable<Types.DareVersatileInformations> dares;
        
        public DareVersatileListMessage()
        {
        }
        
        public DareVersatileListMessage(IEnumerable<Types.DareVersatileInformations> dares)
        {
            this.dares = dares;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)dares.Count());
            foreach (var entry in dares)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            dares = new Types.DareVersatileInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (dares as Types.DareVersatileInformations[])[i] = new Types.DareVersatileInformations();
                 (dares as Types.DareVersatileInformations[])[i].Deserialize(reader);
            }
        }
        
    }
    
}