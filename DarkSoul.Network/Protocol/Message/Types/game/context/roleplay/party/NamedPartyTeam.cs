

// Generated on 02/23/2017 18:06:42
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class NamedPartyTeam
    {
        public virtual short TypeId => 469;
        
        public sbyte teamId;
        public string partyName;
        
        public NamedPartyTeam()
        {
        }
        
        public NamedPartyTeam(sbyte teamId, string partyName)
        {
            this.teamId = teamId;
            this.partyName = partyName;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteSByte(teamId);
            writer.WriteUTF(partyName);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            teamId = reader.ReadSByte();
            partyName = reader.ReadUTF();
        }
        
    }
    
}