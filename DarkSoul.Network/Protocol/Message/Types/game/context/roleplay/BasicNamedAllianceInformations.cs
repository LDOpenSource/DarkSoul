

// Generated on 02/23/2017 18:06:41
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class BasicNamedAllianceInformations : BasicAllianceInformations
    {
        public override short TypeId => 418;
        
        public string allianceName;
        
        public BasicNamedAllianceInformations()
        {
        }
        
        public BasicNamedAllianceInformations(uint allianceId, string allianceTag, string allianceName)
         : base(allianceId, allianceTag)
        {
            this.allianceName = allianceName;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(allianceName);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            allianceName = reader.ReadUTF();
        }
        
    }
    
}