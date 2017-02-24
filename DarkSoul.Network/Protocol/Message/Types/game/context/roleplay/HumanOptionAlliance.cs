

// Generated on 02/23/2017 18:06:42
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class HumanOptionAlliance : HumanOption
    {
        public override short TypeId => 425;
        
        public Types.AllianceInformations allianceInformations;
        public sbyte aggressable;
        
        public HumanOptionAlliance()
        {
        }
        
        public HumanOptionAlliance(Types.AllianceInformations allianceInformations, sbyte aggressable)
        {
            this.allianceInformations = allianceInformations;
            this.aggressable = aggressable;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            allianceInformations.Serialize(writer);
            writer.WriteSByte(aggressable);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            allianceInformations = new Types.AllianceInformations();
            allianceInformations.Deserialize(reader);
            aggressable = reader.ReadSByte();
        }
        
    }
    
}