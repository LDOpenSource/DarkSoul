

// Generated on 02/23/2017 18:06:45
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class HouseInformationsForSell
    {
        public virtual short TypeId => 221;
        
        public uint instanceId;
        public bool secondHand;
        public uint modelId;
        public string ownerName;
        public bool ownerConnected;
        public short worldX;
        public short worldY;
        public ushort subAreaId;
        public sbyte nbRoom;
        public sbyte nbChest;
        public IEnumerable<int> skillListIds;
        public bool isLocked;
        public double price;
        
        public HouseInformationsForSell()
        {
        }
        
        public HouseInformationsForSell(uint instanceId, bool secondHand, uint modelId, string ownerName, bool ownerConnected, short worldX, short worldY, ushort subAreaId, sbyte nbRoom, sbyte nbChest, IEnumerable<int> skillListIds, bool isLocked, double price)
        {
            this.instanceId = instanceId;
            this.secondHand = secondHand;
            this.modelId = modelId;
            this.ownerName = ownerName;
            this.ownerConnected = ownerConnected;
            this.worldX = worldX;
            this.worldY = worldY;
            this.subAreaId = subAreaId;
            this.nbRoom = nbRoom;
            this.nbChest = nbChest;
            this.skillListIds = skillListIds;
            this.isLocked = isLocked;
            this.price = price;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteUInt(instanceId);
            writer.WriteBoolean(secondHand);
            writer.WriteVarInt((int)modelId);
            writer.WriteUTF(ownerName);
            writer.WriteBoolean(ownerConnected);
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            writer.WriteVarShort((int)subAreaId);
            writer.WriteSByte(nbRoom);
            writer.WriteSByte(nbChest);
            writer.WriteShort((short)skillListIds.Count());
            foreach (var entry in skillListIds)
            {
                 writer.WriteInt(entry);
            }
            writer.WriteBoolean(isLocked);
            writer.WriteVarLong(price);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            instanceId = reader.ReadUInt();
            secondHand = reader.ReadBoolean();
            modelId = reader.ReadVarUhInt();
            ownerName = reader.ReadUTF();
            ownerConnected = reader.ReadBoolean();
            worldX = reader.ReadShort();
            worldY = reader.ReadShort();
            subAreaId = reader.ReadVarUhShort();
            nbRoom = reader.ReadSByte();
            nbChest = reader.ReadSByte();
            var limit = reader.ReadUShort();
            skillListIds = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 (skillListIds as int[])[i] = reader.ReadInt();
            }
            isLocked = reader.ReadBoolean();
            price = reader.ReadVarUhLong();
        }
        
    }
    
}