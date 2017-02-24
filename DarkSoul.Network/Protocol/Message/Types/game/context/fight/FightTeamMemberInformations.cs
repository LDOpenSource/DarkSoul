

// Generated on 02/23/2017 18:06:39
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class FightTeamMemberInformations
    {
        public virtual short TypeId => 44;
        
        public double id;
        
        public FightTeamMemberInformations()
        {
        }
        
        public FightTeamMemberInformations(double id)
        {
            this.id = id;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteDouble(id);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            id = reader.ReadDouble();
        }
        
    }
    
}