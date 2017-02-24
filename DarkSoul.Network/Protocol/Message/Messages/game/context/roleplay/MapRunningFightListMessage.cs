

// Generated on 02/23/2017 16:53:34
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class MapRunningFightListMessage : NetworkMessage
    {
        public override ushort Id => 5743;
        
        
        public IEnumerable<Types.FightExternalInformations> fights;
        
        public MapRunningFightListMessage()
        {
        }
        
        public MapRunningFightListMessage(IEnumerable<Types.FightExternalInformations> fights)
        {
            this.fights = fights;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)fights.Count());
            foreach (var entry in fights)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            fights = new Types.FightExternalInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (fights as Types.FightExternalInformations[])[i] = new Types.FightExternalInformations();
                 (fights as Types.FightExternalInformations[])[i].Deserialize(reader);
            }
        }
        
    }
    
}