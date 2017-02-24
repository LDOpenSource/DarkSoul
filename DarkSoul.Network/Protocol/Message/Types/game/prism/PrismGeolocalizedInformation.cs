

// Generated on 02/23/2017 18:06:46
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class PrismGeolocalizedInformation : PrismSubareaEmptyInfo
    {
        public override short TypeId => 434;
        
        public short worldX;
        public short worldY;
        public int mapId;
        public Types.PrismInformation prism;
        
        public PrismGeolocalizedInformation()
        {
        }
        
        public PrismGeolocalizedInformation(ushort subAreaId, uint allianceId, short worldX, short worldY, int mapId, Types.PrismInformation prism)
         : base(subAreaId, allianceId)
        {
            this.worldX = worldX;
            this.worldY = worldY;
            this.mapId = mapId;
            this.prism = prism;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            writer.WriteInt(mapId);
            writer.WriteShort(prism.TypeId);
            prism.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            worldX = reader.ReadShort();
            worldY = reader.ReadShort();
            mapId = reader.ReadInt();
            prism = ProtocolTypeManager.GetInstance<Types.PrismInformation>(reader.ReadUShort());
            prism.Deserialize(reader);
        }
        
    }
    
}