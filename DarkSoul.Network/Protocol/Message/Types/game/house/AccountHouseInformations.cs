

// Generated on 02/23/2017 18:06:45
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class AccountHouseInformations : HouseInformations
    {
        public override short TypeId => 390;
        
        public uint instanceId;
        public bool secondHand;
        public short worldX;
        public short worldY;
        public int mapId;
        public ushort subAreaId;
        
        public AccountHouseInformations()
        {
        }
        
        public AccountHouseInformations(uint houseId, ushort modelId, uint instanceId, bool secondHand, short worldX, short worldY, int mapId, ushort subAreaId)
         : base(houseId, modelId)
        {
            this.instanceId = instanceId;
            this.secondHand = secondHand;
            this.worldX = worldX;
            this.worldY = worldY;
            this.mapId = mapId;
            this.subAreaId = subAreaId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUInt(instanceId);
            writer.WriteBoolean(secondHand);
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            writer.WriteInt(mapId);
            writer.WriteVarShort((int)subAreaId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            instanceId = reader.ReadUInt();
            secondHand = reader.ReadBoolean();
            worldX = reader.ReadShort();
            worldY = reader.ReadShort();
            mapId = reader.ReadInt();
            subAreaId = reader.ReadVarUhShort();
        }
        
    }
    
}