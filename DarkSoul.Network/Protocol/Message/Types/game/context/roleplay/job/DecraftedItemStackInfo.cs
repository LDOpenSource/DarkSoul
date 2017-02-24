

// Generated on 02/23/2017 18:06:42
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class DecraftedItemStackInfo
    {
        public virtual short TypeId => 481;
        
        public uint objectUID;
        public float bonusMin;
        public float bonusMax;
        public IEnumerable<ushort> runesId;
        public IEnumerable<uint> runesQty;
        
        public DecraftedItemStackInfo()
        {
        }
        
        public DecraftedItemStackInfo(uint objectUID, float bonusMin, float bonusMax, IEnumerable<ushort> runesId, IEnumerable<uint> runesQty)
        {
            this.objectUID = objectUID;
            this.bonusMin = bonusMin;
            this.bonusMax = bonusMax;
            this.runesId = runesId;
            this.runesQty = runesQty;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)objectUID);
            writer.WriteFloat(bonusMin);
            writer.WriteFloat(bonusMax);
            writer.WriteShort((short)runesId.Count());
            foreach (var entry in runesId)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteShort((short)runesQty.Count());
            foreach (var entry in runesQty)
            {
                 writer.WriteVarInt((int)entry);
            }
        }
        
        public virtual void Deserialize(IReader reader)
        {
            objectUID = reader.ReadVarUhInt();
            bonusMin = reader.ReadFloat();
            bonusMax = reader.ReadFloat();
            var limit = reader.ReadUShort();
            runesId = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (runesId as ushort[])[i] = reader.ReadVarUhShort();
            }
            limit = reader.ReadUShort();
            runesQty = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 (runesQty as uint[])[i] = reader.ReadVarUhInt();
            }
        }
        
    }
    
}