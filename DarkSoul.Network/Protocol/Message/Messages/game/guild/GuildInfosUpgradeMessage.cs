

// Generated on 02/23/2017 16:53:48
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GuildInfosUpgradeMessage : NetworkMessage
    {
        public override ushort Id => 5636;
        
        
        public sbyte maxTaxCollectorsCount;
        public sbyte taxCollectorsCount;
        public ushort taxCollectorLifePoints;
        public ushort taxCollectorDamagesBonuses;
        public ushort taxCollectorPods;
        public ushort taxCollectorProspecting;
        public ushort taxCollectorWisdom;
        public ushort boostPoints;
        public IEnumerable<ushort> spellId;
        public IEnumerable<short> spellLevel;
        
        public GuildInfosUpgradeMessage()
        {
        }
        
        public GuildInfosUpgradeMessage(sbyte maxTaxCollectorsCount, sbyte taxCollectorsCount, ushort taxCollectorLifePoints, ushort taxCollectorDamagesBonuses, ushort taxCollectorPods, ushort taxCollectorProspecting, ushort taxCollectorWisdom, ushort boostPoints, IEnumerable<ushort> spellId, IEnumerable<short> spellLevel)
        {
            this.maxTaxCollectorsCount = maxTaxCollectorsCount;
            this.taxCollectorsCount = taxCollectorsCount;
            this.taxCollectorLifePoints = taxCollectorLifePoints;
            this.taxCollectorDamagesBonuses = taxCollectorDamagesBonuses;
            this.taxCollectorPods = taxCollectorPods;
            this.taxCollectorProspecting = taxCollectorProspecting;
            this.taxCollectorWisdom = taxCollectorWisdom;
            this.boostPoints = boostPoints;
            this.spellId = spellId;
            this.spellLevel = spellLevel;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(maxTaxCollectorsCount);
            writer.WriteSByte(taxCollectorsCount);
            writer.WriteVarShort((int)taxCollectorLifePoints);
            writer.WriteVarShort((int)taxCollectorDamagesBonuses);
            writer.WriteVarShort((int)taxCollectorPods);
            writer.WriteVarShort((int)taxCollectorProspecting);
            writer.WriteVarShort((int)taxCollectorWisdom);
            writer.WriteVarShort((int)boostPoints);
            writer.WriteShort((short)spellId.Count());
            foreach (var entry in spellId)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteShort((short)spellLevel.Count());
            foreach (var entry in spellLevel)
            {
                 writer.WriteShort(entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            maxTaxCollectorsCount = reader.ReadSByte();
            taxCollectorsCount = reader.ReadSByte();
            taxCollectorLifePoints = reader.ReadVarUhShort();
            taxCollectorDamagesBonuses = reader.ReadVarUhShort();
            taxCollectorPods = reader.ReadVarUhShort();
            taxCollectorProspecting = reader.ReadVarUhShort();
            taxCollectorWisdom = reader.ReadVarUhShort();
            boostPoints = reader.ReadVarUhShort();
            var limit = reader.ReadUShort();
            spellId = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (spellId as ushort[])[i] = reader.ReadVarUhShort();
            }
            limit = reader.ReadUShort();
            spellLevel = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 (spellLevel as short[])[i] = reader.ReadShort();
            }
        }
        
    }
    
}