

// Generated on 02/23/2017 16:53:31
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameFightStartMessage : NetworkMessage
    {
        public override ushort Id => 712;
        
        
        public IEnumerable<Types.Idol> idols;
        
        public GameFightStartMessage()
        {
        }
        
        public GameFightStartMessage(IEnumerable<Types.Idol> idols)
        {
            this.idols = idols;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)idols.Count());
            foreach (var entry in idols)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            idols = new Types.Idol[limit];
            for (int i = 0; i < limit; i++)
            {
                 (idols as Types.Idol[])[i] = new Types.Idol();
                 (idols as Types.Idol[])[i].Deserialize(reader);
            }
        }
        
    }
    
}