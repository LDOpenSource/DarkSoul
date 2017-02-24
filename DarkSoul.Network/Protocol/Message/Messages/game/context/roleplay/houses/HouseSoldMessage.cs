

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
    public class HouseSoldMessage : NetworkMessage
    {
        public override ushort Id => 5737;
        
        
        public uint houseId;
        public uint instanceId;
        public bool secondHand;
        public double realPrice;
        public string buyerName;
        
        public HouseSoldMessage()
        {
        }
        
        public HouseSoldMessage(uint houseId, uint instanceId, bool secondHand, double realPrice, string buyerName)
        {
            this.houseId = houseId;
            this.instanceId = instanceId;
            this.secondHand = secondHand;
            this.realPrice = realPrice;
            this.buyerName = buyerName;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)houseId);
            writer.WriteUInt(instanceId);
            writer.WriteBoolean(secondHand);
            writer.WriteVarLong(realPrice);
            writer.WriteUTF(buyerName);
        }
        
        public override void Deserialize(IReader reader)
        {
            houseId = reader.ReadVarUhInt();
            instanceId = reader.ReadUInt();
            secondHand = reader.ReadBoolean();
            realPrice = reader.ReadVarUhLong();
            buyerName = reader.ReadUTF();
        }
        
    }
    
}