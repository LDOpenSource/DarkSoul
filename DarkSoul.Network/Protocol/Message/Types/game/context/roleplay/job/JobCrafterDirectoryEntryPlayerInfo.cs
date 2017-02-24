

// Generated on 02/23/2017 18:06:42
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class JobCrafterDirectoryEntryPlayerInfo
    {
        public virtual short TypeId => 194;
        
        public double playerId;
        public string playerName;
        public sbyte alignmentSide;
        public sbyte breed;
        public bool sex;
        public bool isInWorkshop;
        public short worldX;
        public short worldY;
        public int mapId;
        public ushort subAreaId;
        public Types.PlayerStatus status;
        
        public JobCrafterDirectoryEntryPlayerInfo()
        {
        }
        
        public JobCrafterDirectoryEntryPlayerInfo(double playerId, string playerName, sbyte alignmentSide, sbyte breed, bool sex, bool isInWorkshop, short worldX, short worldY, int mapId, ushort subAreaId, Types.PlayerStatus status)
        {
            this.playerId = playerId;
            this.playerName = playerName;
            this.alignmentSide = alignmentSide;
            this.breed = breed;
            this.sex = sex;
            this.isInWorkshop = isInWorkshop;
            this.worldX = worldX;
            this.worldY = worldY;
            this.mapId = mapId;
            this.subAreaId = subAreaId;
            this.status = status;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteVarLong(playerId);
            writer.WriteUTF(playerName);
            writer.WriteSByte(alignmentSide);
            writer.WriteSByte(breed);
            writer.WriteBoolean(sex);
            writer.WriteBoolean(isInWorkshop);
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            writer.WriteInt(mapId);
            writer.WriteVarShort((int)subAreaId);
            writer.WriteShort(status.TypeId);
            status.Serialize(writer);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            playerId = reader.ReadVarUhLong();
            playerName = reader.ReadUTF();
            alignmentSide = reader.ReadSByte();
            breed = reader.ReadSByte();
            sex = reader.ReadBoolean();
            isInWorkshop = reader.ReadBoolean();
            worldX = reader.ReadShort();
            worldY = reader.ReadShort();
            mapId = reader.ReadInt();
            subAreaId = reader.ReadVarUhShort();
            status = ProtocolTypeManager.GetInstance<Types.PlayerStatus>(reader.ReadUShort());
            status.Deserialize(reader);
        }
        
    }
    
}