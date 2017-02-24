

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
    public class DareListMessage : NetworkMessage
    {
        public override ushort Id => 6661;
        
        
        public IEnumerable<Types.DareInformations> dares;
        
        public DareListMessage()
        {
        }
        
        public DareListMessage(IEnumerable<Types.DareInformations> dares)
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
            dares = new Types.DareInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (dares as Types.DareInformations[])[i] = new Types.DareInformations();
                 (dares as Types.DareInformations[])[i].Deserialize(reader);
            }
        }
        
    }
    
}