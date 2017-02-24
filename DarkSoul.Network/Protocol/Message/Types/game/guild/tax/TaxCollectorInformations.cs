

// Generated on 02/23/2017 18:06:45
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class TaxCollectorInformations
    {
        public virtual short TypeId => 167;
        
        public int uniqueId;
        public ushort firtNameId;
        public ushort lastNameId;
        public Types.AdditionalTaxCollectorInformations additionalInfos;
        public short worldX;
        public short worldY;
        public ushort subAreaId;
        public sbyte state;
        public Types.EntityLook look;
        public IEnumerable<Types.TaxCollectorComplementaryInformations> complements;
        
        public TaxCollectorInformations()
        {
        }
        
        public TaxCollectorInformations(int uniqueId, ushort firtNameId, ushort lastNameId, Types.AdditionalTaxCollectorInformations additionalInfos, short worldX, short worldY, ushort subAreaId, sbyte state, Types.EntityLook look, IEnumerable<Types.TaxCollectorComplementaryInformations> complements)
        {
            this.uniqueId = uniqueId;
            this.firtNameId = firtNameId;
            this.lastNameId = lastNameId;
            this.additionalInfos = additionalInfos;
            this.worldX = worldX;
            this.worldY = worldY;
            this.subAreaId = subAreaId;
            this.state = state;
            this.look = look;
            this.complements = complements;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteInt(uniqueId);
            writer.WriteVarShort((int)firtNameId);
            writer.WriteVarShort((int)lastNameId);
            additionalInfos.Serialize(writer);
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            writer.WriteVarShort((int)subAreaId);
            writer.WriteSByte(state);
            look.Serialize(writer);
            writer.WriteShort((short)complements.Count());
            foreach (var entry in complements)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
        }
        
        public virtual void Deserialize(IReader reader)
        {
            uniqueId = reader.ReadInt();
            firtNameId = reader.ReadVarUhShort();
            lastNameId = reader.ReadVarUhShort();
            additionalInfos = new Types.AdditionalTaxCollectorInformations();
            additionalInfos.Deserialize(reader);
            worldX = reader.ReadShort();
            worldY = reader.ReadShort();
            subAreaId = reader.ReadVarUhShort();
            state = reader.ReadSByte();
            look = new Types.EntityLook();
            look.Deserialize(reader);
            var limit = reader.ReadUShort();
            complements = new Types.TaxCollectorComplementaryInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (complements as Types.TaxCollectorComplementaryInformations[])[i] = ProtocolTypeManager.GetInstance<Types.TaxCollectorComplementaryInformations>(reader.ReadUShort());
                 (complements as Types.TaxCollectorComplementaryInformations[])[i].Deserialize(reader);
            }
        }
        
    }
    
}