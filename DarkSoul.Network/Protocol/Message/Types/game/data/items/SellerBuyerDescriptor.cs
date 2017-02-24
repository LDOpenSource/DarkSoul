

// Generated on 02/23/2017 18:06:44
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class SellerBuyerDescriptor
    {
        public virtual short TypeId => 121;
        
        public IEnumerable<uint> quantities;
        public IEnumerable<uint> types;
        public float taxPercentage;
        public float taxModificationPercentage;
        public byte maxItemLevel;
        public uint maxItemPerAccount;
        public int npcContextualId;
        public ushort unsoldDelay;
        
        public SellerBuyerDescriptor()
        {
        }
        
        public SellerBuyerDescriptor(IEnumerable<uint> quantities, IEnumerable<uint> types, float taxPercentage, float taxModificationPercentage, byte maxItemLevel, uint maxItemPerAccount, int npcContextualId, ushort unsoldDelay)
        {
            this.quantities = quantities;
            this.types = types;
            this.taxPercentage = taxPercentage;
            this.taxModificationPercentage = taxModificationPercentage;
            this.maxItemLevel = maxItemLevel;
            this.maxItemPerAccount = maxItemPerAccount;
            this.npcContextualId = npcContextualId;
            this.unsoldDelay = unsoldDelay;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteShort((short)quantities.Count());
            foreach (var entry in quantities)
            {
                 writer.WriteVarInt((int)entry);
            }
            writer.WriteShort((short)types.Count());
            foreach (var entry in types)
            {
                 writer.WriteVarInt((int)entry);
            }
            writer.WriteFloat(taxPercentage);
            writer.WriteFloat(taxModificationPercentage);
            writer.WriteByte(maxItemLevel);
            writer.WriteVarInt((int)maxItemPerAccount);
            writer.WriteInt(npcContextualId);
            writer.WriteVarShort((int)unsoldDelay);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            quantities = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 (quantities as uint[])[i] = reader.ReadVarUhInt();
            }
            limit = reader.ReadUShort();
            types = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 (types as uint[])[i] = reader.ReadVarUhInt();
            }
            taxPercentage = reader.ReadFloat();
            taxModificationPercentage = reader.ReadFloat();
            maxItemLevel = reader.ReadByte();
            maxItemPerAccount = reader.ReadVarUhInt();
            npcContextualId = reader.ReadInt();
            unsoldDelay = reader.ReadVarUhShort();
        }
        
    }
    
}