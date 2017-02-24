

// Generated on 02/23/2017 16:53:21
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class AllianceChangeGuildRightsMessage : NetworkMessage
    {
        public override ushort Id => 6426;
        
        
        public uint guildId;
        public sbyte rights;
        
        public AllianceChangeGuildRightsMessage()
        {
        }
        
        public AllianceChangeGuildRightsMessage(uint guildId, sbyte rights)
        {
            this.guildId = guildId;
            this.rights = rights;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)guildId);
            writer.WriteSByte(rights);
        }
        
        public override void Deserialize(IReader reader)
        {
            guildId = reader.ReadVarUhInt();
            rights = reader.ReadSByte();
        }
        
    }
    
}