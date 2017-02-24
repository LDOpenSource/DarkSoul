

// Generated on 02/23/2017 18:06:43
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class PartyMemberGeoPosition
    {
        public virtual short TypeId => 378;
        
        public int memberId;
        public short worldX;
        public short worldY;
        public int mapId;
        public ushort subAreaId;
        
        public PartyMemberGeoPosition()
        {
        }
        
        public PartyMemberGeoPosition(int memberId, short worldX, short worldY, int mapId, ushort subAreaId)
        {
            this.memberId = memberId;
            this.worldX = worldX;
            this.worldY = worldY;
            this.mapId = mapId;
            this.subAreaId = subAreaId;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteInt(memberId);
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            writer.WriteInt(mapId);
            writer.WriteVarShort((int)subAreaId);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            memberId = reader.ReadInt();
            worldX = reader.ReadShort();
            worldY = reader.ReadShort();
            mapId = reader.ReadInt();
            subAreaId = reader.ReadVarUhShort();
        }
        
    }
    
}