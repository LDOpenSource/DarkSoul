

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
    public class LivingObjectDissociateMessage : NetworkMessage
    {
        public override ushort Id => 5723;
        
        
        public uint livingUID;
        public byte livingPosition;
        
        public LivingObjectDissociateMessage()
        {
        }
        
        public LivingObjectDissociateMessage(uint livingUID, byte livingPosition)
        {
            this.livingUID = livingUID;
            this.livingPosition = livingPosition;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)livingUID);
            writer.WriteByte(livingPosition);
        }
        
        public override void Deserialize(IReader reader)
        {
            livingUID = reader.ReadVarUhInt();
            livingPosition = reader.ReadByte();
        }
        
    }
    
}