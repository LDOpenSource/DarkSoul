

// Generated on 02/23/2017 16:53:38
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class HouseGuildShareRequestMessage : NetworkMessage
    {
        public override ushort Id => 5704;
        
        
        public uint houseId;
        public uint instanceId;
        public bool enable;
        public uint rights;
        
        public HouseGuildShareRequestMessage()
        {
        }
        
        public HouseGuildShareRequestMessage(uint houseId, uint instanceId, bool enable, uint rights)
        {
            this.houseId = houseId;
            this.instanceId = instanceId;
            this.enable = enable;
            this.rights = rights;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)houseId);
            writer.WriteUInt(instanceId);
            writer.WriteBoolean(enable);
            writer.WriteVarInt((int)rights);
        }
        
        public override void Deserialize(IReader reader)
        {
            houseId = reader.ReadVarUhInt();
            instanceId = reader.ReadUInt();
            enable = reader.ReadBoolean();
            rights = reader.ReadVarUhInt();
        }
        
    }
    
}