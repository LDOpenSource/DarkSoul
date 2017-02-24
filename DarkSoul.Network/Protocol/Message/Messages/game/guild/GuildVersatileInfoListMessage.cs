

// Generated on 02/23/2017 16:53:49
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GuildVersatileInfoListMessage : NetworkMessage
    {
        public override ushort Id => 6435;
        
        
        public IEnumerable<Types.GuildVersatileInformations> guilds;
        
        public GuildVersatileInfoListMessage()
        {
        }
        
        public GuildVersatileInfoListMessage(IEnumerable<Types.GuildVersatileInformations> guilds)
        {
            this.guilds = guilds;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)guilds.Count());
            foreach (var entry in guilds)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            guilds = new Types.GuildVersatileInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (guilds as Types.GuildVersatileInformations[])[i] = ProtocolTypeManager.GetInstance<Types.GuildVersatileInformations>(reader.ReadUShort());
                 (guilds as Types.GuildVersatileInformations[])[i].Deserialize(reader);
            }
        }
        
    }
    
}