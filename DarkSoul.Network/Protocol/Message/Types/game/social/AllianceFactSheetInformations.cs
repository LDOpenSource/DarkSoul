

// Generated on 02/23/2017 18:06:47
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class AllianceFactSheetInformations : AllianceInformations
    {
        public override short TypeId => 421;
        
        public int creationDate;
        
        public AllianceFactSheetInformations()
        {
        }
        
        public AllianceFactSheetInformations(uint allianceId, string allianceTag, string allianceName, Types.GuildEmblem allianceEmblem, int creationDate)
         : base(allianceId, allianceTag, allianceName, allianceEmblem)
        {
            this.creationDate = creationDate;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteInt(creationDate);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            creationDate = reader.ReadInt();
        }
        
    }
    
}