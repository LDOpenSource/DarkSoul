

// Generated on 02/23/2017 18:06:46
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class PrismSubareaEmptyInfo
    {
        public virtual short TypeId => 438;
        
        public ushort subAreaId;
        public uint allianceId;
        
        public PrismSubareaEmptyInfo()
        {
        }
        
        public PrismSubareaEmptyInfo(ushort subAreaId, uint allianceId)
        {
            this.subAreaId = subAreaId;
            this.allianceId = allianceId;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)subAreaId);
            writer.WriteVarInt((int)allianceId);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            subAreaId = reader.ReadVarUhShort();
            allianceId = reader.ReadVarUhInt();
        }
        
    }
    
}