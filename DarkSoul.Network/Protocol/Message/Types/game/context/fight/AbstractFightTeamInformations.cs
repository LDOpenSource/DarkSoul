

// Generated on 02/23/2017 18:06:39
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class AbstractFightTeamInformations
    {
        public virtual short TypeId => 116;
        
        public sbyte teamId;
        public double leaderId;
        public sbyte teamSide;
        public sbyte teamTypeId;
        public sbyte nbWaves;
        
        public AbstractFightTeamInformations()
        {
        }
        
        public AbstractFightTeamInformations(sbyte teamId, double leaderId, sbyte teamSide, sbyte teamTypeId, sbyte nbWaves)
        {
            this.teamId = teamId;
            this.leaderId = leaderId;
            this.teamSide = teamSide;
            this.teamTypeId = teamTypeId;
            this.nbWaves = nbWaves;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteSByte(teamId);
            writer.WriteDouble(leaderId);
            writer.WriteSByte(teamSide);
            writer.WriteSByte(teamTypeId);
            writer.WriteSByte(nbWaves);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            teamId = reader.ReadSByte();
            leaderId = reader.ReadDouble();
            teamSide = reader.ReadSByte();
            teamTypeId = reader.ReadSByte();
            nbWaves = reader.ReadSByte();
        }
        
    }
    
}