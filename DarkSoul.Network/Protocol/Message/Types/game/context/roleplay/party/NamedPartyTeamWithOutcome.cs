

// Generated on 02/23/2017 18:06:42
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class NamedPartyTeamWithOutcome
    {
        public virtual short TypeId => 470;
        
        public Types.NamedPartyTeam team;
        public ushort outcome;
        
        public NamedPartyTeamWithOutcome()
        {
        }
        
        public NamedPartyTeamWithOutcome(Types.NamedPartyTeam team, ushort outcome)
        {
            this.team = team;
            this.outcome = outcome;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            team.Serialize(writer);
            writer.WriteVarShort((int)outcome);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            team = new Types.NamedPartyTeam();
            team.Deserialize(reader);
            outcome = reader.ReadVarUhShort();
        }
        
    }
    
}