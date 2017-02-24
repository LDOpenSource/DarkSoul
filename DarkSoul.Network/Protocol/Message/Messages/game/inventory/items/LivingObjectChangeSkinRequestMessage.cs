

// Generated on 02/23/2017 16:53:58
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class LivingObjectChangeSkinRequestMessage : NetworkMessage
    {
        public override ushort Id => 5725;
        
        
        public uint livingUID;
        public byte livingPosition;
        public uint skinId;
        
        public LivingObjectChangeSkinRequestMessage()
        {
        }
        
        public LivingObjectChangeSkinRequestMessage(uint livingUID, byte livingPosition, uint skinId)
        {
            this.livingUID = livingUID;
            this.livingPosition = livingPosition;
            this.skinId = skinId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)livingUID);
            writer.WriteByte(livingPosition);
            writer.WriteVarInt((int)skinId);
        }
        
        public override void Deserialize(IReader reader)
        {
            livingUID = reader.ReadVarUhInt();
            livingPosition = reader.ReadByte();
            skinId = reader.ReadVarUhInt();
        }
        
    }
    
}