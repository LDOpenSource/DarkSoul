

// Generated on 02/23/2017 18:06:41
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class BasicAllianceInformations : AbstractSocialGroupInfos
    {
        public override short TypeId => 419;
        
        public uint allianceId;
        public string allianceTag;
        
        public BasicAllianceInformations()
        {
        }
        
        public BasicAllianceInformations(uint allianceId, string allianceTag)
        {
            this.allianceId = allianceId;
            this.allianceTag = allianceTag;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt((int)allianceId);
            writer.WriteUTF(allianceTag);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            allianceId = reader.ReadVarUhInt();
            allianceTag = reader.ReadUTF();
        }
        
    }
    
}