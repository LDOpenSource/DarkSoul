

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
    public class HouseGuildNoneMessage : NetworkMessage
    {
        public override ushort Id => 5701;
        
        
        public uint houseId;
        public uint instanceId;
        public bool secondHand;
        
        public HouseGuildNoneMessage()
        {
        }
        
        public HouseGuildNoneMessage(uint houseId, uint instanceId, bool secondHand)
        {
            this.houseId = houseId;
            this.instanceId = instanceId;
            this.secondHand = secondHand;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)houseId);
            writer.WriteUInt(instanceId);
            writer.WriteBoolean(secondHand);
        }
        
        public override void Deserialize(IReader reader)
        {
            houseId = reader.ReadVarUhInt();
            instanceId = reader.ReadUInt();
            secondHand = reader.ReadBoolean();
        }
        
    }
    
}