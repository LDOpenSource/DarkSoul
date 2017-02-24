

// Generated on 02/23/2017 18:06:46
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class AllianceInsiderPrismInformation : PrismInformation
    {
        public override short TypeId => 431;
        
        public int lastTimeSlotModificationDate;
        public uint lastTimeSlotModificationAuthorGuildId;
        public double lastTimeSlotModificationAuthorId;
        public string lastTimeSlotModificationAuthorName;
        public IEnumerable<Types.ObjectItem> modulesObjects;
        
        public AllianceInsiderPrismInformation()
        {
        }
        
        public AllianceInsiderPrismInformation(sbyte typeId, sbyte state, int nextVulnerabilityDate, int placementDate, uint rewardTokenCount, int lastTimeSlotModificationDate, uint lastTimeSlotModificationAuthorGuildId, double lastTimeSlotModificationAuthorId, string lastTimeSlotModificationAuthorName, IEnumerable<Types.ObjectItem> modulesObjects)
         : base(typeId, state, nextVulnerabilityDate, placementDate, rewardTokenCount)
        {
            this.lastTimeSlotModificationDate = lastTimeSlotModificationDate;
            this.lastTimeSlotModificationAuthorGuildId = lastTimeSlotModificationAuthorGuildId;
            this.lastTimeSlotModificationAuthorId = lastTimeSlotModificationAuthorId;
            this.lastTimeSlotModificationAuthorName = lastTimeSlotModificationAuthorName;
            this.modulesObjects = modulesObjects;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteInt(lastTimeSlotModificationDate);
            writer.WriteVarInt((int)lastTimeSlotModificationAuthorGuildId);
            writer.WriteVarLong(lastTimeSlotModificationAuthorId);
            writer.WriteUTF(lastTimeSlotModificationAuthorName);
            writer.WriteShort((short)modulesObjects.Count());
            foreach (var entry in modulesObjects)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            lastTimeSlotModificationDate = reader.ReadInt();
            lastTimeSlotModificationAuthorGuildId = reader.ReadVarUhInt();
            lastTimeSlotModificationAuthorId = reader.ReadVarUhLong();
            lastTimeSlotModificationAuthorName = reader.ReadUTF();
            var limit = reader.ReadUShort();
            modulesObjects = new Types.ObjectItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 (modulesObjects as Types.ObjectItem[])[i] = new Types.ObjectItem();
                 (modulesObjects as Types.ObjectItem[])[i].Deserialize(reader);
            }
        }
        
    }
    
}