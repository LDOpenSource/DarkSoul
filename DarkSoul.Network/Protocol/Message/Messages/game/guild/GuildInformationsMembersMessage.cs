

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
    public class GuildInformationsMembersMessage : NetworkMessage
    {
        public override ushort Id => 5558;
        
        
        public IEnumerable<Types.GuildMember> members;
        
        public GuildInformationsMembersMessage()
        {
        }
        
        public GuildInformationsMembersMessage(IEnumerable<Types.GuildMember> members)
        {
            this.members = members;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)members.Count());
            foreach (var entry in members)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            members = new Types.GuildMember[limit];
            for (int i = 0; i < limit; i++)
            {
                 (members as Types.GuildMember[])[i] = new Types.GuildMember();
                 (members as Types.GuildMember[])[i].Deserialize(reader);
            }
        }
        
    }
    
}