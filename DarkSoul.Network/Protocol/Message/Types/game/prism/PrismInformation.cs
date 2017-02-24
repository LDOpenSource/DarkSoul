

// Generated on 02/23/2017 18:06:46
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class PrismInformation
    {
        public virtual short TypeId => 428;
        
        public sbyte typeId;
        public sbyte state;
        public int nextVulnerabilityDate;
        public int placementDate;
        public uint rewardTokenCount;
        
        public PrismInformation()
        {
        }
        
        public PrismInformation(sbyte typeId, sbyte state, int nextVulnerabilityDate, int placementDate, uint rewardTokenCount)
        {
            this.typeId = typeId;
            this.state = state;
            this.nextVulnerabilityDate = nextVulnerabilityDate;
            this.placementDate = placementDate;
            this.rewardTokenCount = rewardTokenCount;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteSByte(typeId);
            writer.WriteSByte(state);
            writer.WriteInt(nextVulnerabilityDate);
            writer.WriteInt(placementDate);
            writer.WriteVarInt((int)rewardTokenCount);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            typeId = reader.ReadSByte();
            state = reader.ReadSByte();
            nextVulnerabilityDate = reader.ReadInt();
            placementDate = reader.ReadInt();
            rewardTokenCount = reader.ReadVarUhInt();
        }
        
    }
    
}