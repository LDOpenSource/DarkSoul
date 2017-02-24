

// Generated on 02/23/2017 18:06:45
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class TaxCollectorBasicInformations
    {
        public virtual short TypeId => 96;
        
        public ushort firstNameId;
        public ushort lastNameId;
        public short worldX;
        public short worldY;
        public int mapId;
        public ushort subAreaId;
        
        public TaxCollectorBasicInformations()
        {
        }
        
        public TaxCollectorBasicInformations(ushort firstNameId, ushort lastNameId, short worldX, short worldY, int mapId, ushort subAreaId)
        {
            this.firstNameId = firstNameId;
            this.lastNameId = lastNameId;
            this.worldX = worldX;
            this.worldY = worldY;
            this.mapId = mapId;
            this.subAreaId = subAreaId;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)firstNameId);
            writer.WriteVarShort((int)lastNameId);
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            writer.WriteInt(mapId);
            writer.WriteVarShort((int)subAreaId);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            firstNameId = reader.ReadVarUhShort();
            lastNameId = reader.ReadVarUhShort();
            worldX = reader.ReadShort();
            worldY = reader.ReadShort();
            mapId = reader.ReadInt();
            subAreaId = reader.ReadVarUhShort();
        }
        
    }
    
}