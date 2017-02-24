

// Generated on 02/23/2017 16:53:37
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class HouseGuildRightsMessage : NetworkMessage
    {
        public override ushort Id => 5703;
        
        
        public uint houseId;
        public uint instanceId;
        public bool secondHand;
        public Types.GuildInformations guildInfo;
        public uint rights;
        
        public HouseGuildRightsMessage()
        {
        }
        
        public HouseGuildRightsMessage(uint houseId, uint instanceId, bool secondHand, Types.GuildInformations guildInfo, uint rights)
        {
            this.houseId = houseId;
            this.instanceId = instanceId;
            this.secondHand = secondHand;
            this.guildInfo = guildInfo;
            this.rights = rights;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)houseId);
            writer.WriteUInt(instanceId);
            writer.WriteBoolean(secondHand);
            guildInfo.Serialize(writer);
            writer.WriteVarInt((int)rights);
        }
        
        public override void Deserialize(IReader reader)
        {
            houseId = reader.ReadVarUhInt();
            instanceId = reader.ReadUInt();
            secondHand = reader.ReadBoolean();
            guildInfo = new Types.GuildInformations();
            guildInfo.Deserialize(reader);
            rights = reader.ReadVarUhInt();
        }
        
    }
    
}