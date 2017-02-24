

// Generated on 02/23/2017 18:06:46
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class PaddockContentInformations : PaddockInformations
    {
        public override short TypeId => 183;
        
        public int paddockId;
        public short worldX;
        public short worldY;
        public int mapId;
        public ushort subAreaId;
        public bool abandonned;
        public IEnumerable<Types.MountInformationsForPaddock> mountsInformations;
        
        public PaddockContentInformations()
        {
        }
        
        public PaddockContentInformations(ushort maxOutdoorMount, ushort maxItems, int paddockId, short worldX, short worldY, int mapId, ushort subAreaId, bool abandonned, IEnumerable<Types.MountInformationsForPaddock> mountsInformations)
         : base(maxOutdoorMount, maxItems)
        {
            this.paddockId = paddockId;
            this.worldX = worldX;
            this.worldY = worldY;
            this.mapId = mapId;
            this.subAreaId = subAreaId;
            this.abandonned = abandonned;
            this.mountsInformations = mountsInformations;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteInt(paddockId);
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            writer.WriteInt(mapId);
            writer.WriteVarShort((int)subAreaId);
            writer.WriteBoolean(abandonned);
            writer.WriteShort((short)mountsInformations.Count());
            foreach (var entry in mountsInformations)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            paddockId = reader.ReadInt();
            worldX = reader.ReadShort();
            worldY = reader.ReadShort();
            mapId = reader.ReadInt();
            subAreaId = reader.ReadVarUhShort();
            abandonned = reader.ReadBoolean();
            var limit = reader.ReadUShort();
            mountsInformations = new Types.MountInformationsForPaddock[limit];
            for (int i = 0; i < limit; i++)
            {
                 (mountsInformations as Types.MountInformationsForPaddock[])[i] = new Types.MountInformationsForPaddock();
                 (mountsInformations as Types.MountInformationsForPaddock[])[i].Deserialize(reader);
            }
        }
        
    }
    
}