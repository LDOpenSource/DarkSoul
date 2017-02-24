

// Generated on 02/23/2017 18:06:45
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class HouseInformationsForGuild : HouseInformations
    {
        public override short TypeId => 170;
        
        public uint instanceId;
        public bool secondHand;
        public string ownerName;
        public short worldX;
        public short worldY;
        public int mapId;
        public ushort subAreaId;
        public IEnumerable<int> skillListIds;
        public uint guildshareParams;
        
        public HouseInformationsForGuild()
        {
        }
        
        public HouseInformationsForGuild(uint houseId, ushort modelId, uint instanceId, bool secondHand, string ownerName, short worldX, short worldY, int mapId, ushort subAreaId, IEnumerable<int> skillListIds, uint guildshareParams)
         : base(houseId, modelId)
        {
            this.instanceId = instanceId;
            this.secondHand = secondHand;
            this.ownerName = ownerName;
            this.worldX = worldX;
            this.worldY = worldY;
            this.mapId = mapId;
            this.subAreaId = subAreaId;
            this.skillListIds = skillListIds;
            this.guildshareParams = guildshareParams;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUInt(instanceId);
            writer.WriteBoolean(secondHand);
            writer.WriteUTF(ownerName);
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            writer.WriteInt(mapId);
            writer.WriteVarShort((int)subAreaId);
            writer.WriteShort((short)skillListIds.Count());
            foreach (var entry in skillListIds)
            {
                 writer.WriteInt(entry);
            }
            writer.WriteVarInt((int)guildshareParams);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            instanceId = reader.ReadUInt();
            secondHand = reader.ReadBoolean();
            ownerName = reader.ReadUTF();
            worldX = reader.ReadShort();
            worldY = reader.ReadShort();
            mapId = reader.ReadInt();
            subAreaId = reader.ReadVarUhShort();
            var limit = reader.ReadUShort();
            skillListIds = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 (skillListIds as int[])[i] = reader.ReadInt();
            }
            guildshareParams = reader.ReadVarUhInt();
        }
        
    }
    
}