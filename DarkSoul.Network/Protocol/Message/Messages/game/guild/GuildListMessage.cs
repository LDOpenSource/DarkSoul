

// Generated on 02/23/2017 16:53:48
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GuildListMessage : NetworkMessage
    {
        public override ushort Id => 6413;
        
        
        public IEnumerable<Types.GuildInformations> guilds;
        
        public GuildListMessage()
        {
        }
        
        public GuildListMessage(IEnumerable<Types.GuildInformations> guilds)
        {
            this.guilds = guilds;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)guilds.Count());
            foreach (var entry in guilds)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            guilds = new Types.GuildInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (guilds as Types.GuildInformations[])[i] = new Types.GuildInformations();
                 (guilds as Types.GuildInformations[])[i].Deserialize(reader);
            }
        }
        
    }
    
}