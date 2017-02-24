

// Generated on 02/23/2017 18:06:45
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class HouseInformationsInside : HouseInformations
    {
        public override short TypeId => 218;
        
        public uint instanceId;
        public bool secondHand;
        public int ownerId;
        public string ownerName;
        public short worldX;
        public short worldY;
        public double price;
        public bool isLocked;
        
        public HouseInformationsInside()
        {
        }
        
        public HouseInformationsInside(uint houseId, ushort modelId, uint instanceId, bool secondHand, int ownerId, string ownerName, short worldX, short worldY, double price, bool isLocked)
         : base(houseId, modelId)
        {
            this.instanceId = instanceId;
            this.secondHand = secondHand;
            this.ownerId = ownerId;
            this.ownerName = ownerName;
            this.worldX = worldX;
            this.worldY = worldY;
            this.price = price;
            this.isLocked = isLocked;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUInt(instanceId);
            writer.WriteBoolean(secondHand);
            writer.WriteInt(ownerId);
            writer.WriteUTF(ownerName);
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            writer.WriteVarLong(price);
            writer.WriteBoolean(isLocked);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            instanceId = reader.ReadUInt();
            secondHand = reader.ReadBoolean();
            ownerId = reader.ReadInt();
            ownerName = reader.ReadUTF();
            worldX = reader.ReadShort();
            worldY = reader.ReadShort();
            price = reader.ReadVarUhLong();
            isLocked = reader.ReadBoolean();
        }
        
    }
    
}