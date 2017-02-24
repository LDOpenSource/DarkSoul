

// Generated on 02/23/2017 18:06:46
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class EntityLook
    {
        public virtual short TypeId => 55;
        
        public ushort bonesId;
        public IEnumerable<ushort> skins;
        public IEnumerable<int> indexedColors;
        public IEnumerable<short> scales;
        public IEnumerable<Types.SubEntity> subentities;
        
        public EntityLook()
        {
        }
        
        public EntityLook(ushort bonesId, IEnumerable<ushort> skins, IEnumerable<int> indexedColors, IEnumerable<short> scales, IEnumerable<Types.SubEntity> subentities)
        {
            this.bonesId = bonesId;
            this.skins = skins;
            this.indexedColors = indexedColors;
            this.scales = scales;
            this.subentities = subentities;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)bonesId);
            writer.WriteShort((short)skins.Count());
            foreach (var entry in skins)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteShort((short)indexedColors.Count());
            foreach (var entry in indexedColors)
            {
                 writer.WriteInt(entry);
            }
            writer.WriteShort((short)scales.Count());
            foreach (var entry in scales)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteShort((short)subentities.Count());
            foreach (var entry in subentities)
            {
                 entry.Serialize(writer);
            }
        }
        
        public virtual void Deserialize(IReader reader)
        {
            bonesId = reader.ReadVarUhShort();
            var limit = reader.ReadUShort();
            skins = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (skins as ushort[])[i] = reader.ReadVarUhShort();
            }
            limit = reader.ReadUShort();
            indexedColors = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 (indexedColors as int[])[i] = reader.ReadInt();
            }
            limit = reader.ReadUShort();
            scales = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 (scales as short[])[i] = reader.ReadVarShort();
            }
            limit = reader.ReadUShort();
            subentities = new Types.SubEntity[limit];
            for (int i = 0; i < limit; i++)
            {
                 (subentities as Types.SubEntity[])[i] = new Types.SubEntity();
                 (subentities as Types.SubEntity[])[i].Deserialize(reader);
            }
        }
        
    }
    
}