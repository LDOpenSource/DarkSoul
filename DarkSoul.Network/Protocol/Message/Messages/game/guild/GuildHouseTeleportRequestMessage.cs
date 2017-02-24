

// Generated on 02/23/2017 16:53:47
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GuildHouseTeleportRequestMessage : NetworkMessage
    {
        public override ushort Id => 5712;
        
        
        public uint houseId;
        public int houseInstanceId;
        
        public GuildHouseTeleportRequestMessage()
        {
        }
        
        public GuildHouseTeleportRequestMessage(uint houseId, int houseInstanceId)
        {
            this.houseId = houseId;
            this.houseInstanceId = houseInstanceId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)houseId);
            writer.WriteInt(houseInstanceId);
        }
        
        public override void Deserialize(IReader reader)
        {
            houseId = reader.ReadVarUhInt();
            houseInstanceId = reader.ReadInt();
        }
        
    }
    
}