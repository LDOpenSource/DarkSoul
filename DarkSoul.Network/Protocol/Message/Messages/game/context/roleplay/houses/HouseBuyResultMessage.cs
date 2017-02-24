

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
    public class HouseBuyResultMessage : NetworkMessage
    {
        public override ushort Id => 5735;
        
        
        public bool secondHand;
        public bool bought;
        public uint houseId;
        public uint instanceId;
        public double realPrice;
        
        public HouseBuyResultMessage()
        {
        }
        
        public HouseBuyResultMessage(bool secondHand, bool bought, uint houseId, uint instanceId, double realPrice)
        {
            this.secondHand = secondHand;
            this.bought = bought;
            this.houseId = houseId;
            this.instanceId = instanceId;
            this.realPrice = realPrice;
        }
        
        public override void Serialize(IWriter writer)
        {
            byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, secondHand);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, bought);
            writer.WriteByte(flag1);
            writer.WriteVarInt((int)houseId);
            writer.WriteUInt(instanceId);
            writer.WriteVarLong(realPrice);
        }
        
        public override void Deserialize(IReader reader)
        {
            byte flag1 = reader.ReadByte();
            secondHand = BooleanByteWrapper.GetFlag(flag1, 0);
            bought = BooleanByteWrapper.GetFlag(flag1, 1);
            houseId = reader.ReadVarUhInt();
            instanceId = reader.ReadUInt();
            realPrice = reader.ReadVarUhLong();
        }
        
    }
    
}