

// Generated on 02/23/2017 18:06:39
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class FightCommonInformations
    {
        public virtual short TypeId => 43;
        
        public int fightId;
        public sbyte fightType;
        public IEnumerable<Types.FightTeamInformations> fightTeams;
        public IEnumerable<ushort> fightTeamsPositions;
        public IEnumerable<Types.FightOptionsInformations> fightTeamsOptions;
        
        public FightCommonInformations()
        {
        }
        
        public FightCommonInformations(int fightId, sbyte fightType, IEnumerable<Types.FightTeamInformations> fightTeams, IEnumerable<ushort> fightTeamsPositions, IEnumerable<Types.FightOptionsInformations> fightTeamsOptions)
        {
            this.fightId = fightId;
            this.fightType = fightType;
            this.fightTeams = fightTeams;
            this.fightTeamsPositions = fightTeamsPositions;
            this.fightTeamsOptions = fightTeamsOptions;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteInt(fightId);
            writer.WriteSByte(fightType);
            writer.WriteShort((short)fightTeams.Count());
            foreach (var entry in fightTeams)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)fightTeamsPositions.Count());
            foreach (var entry in fightTeamsPositions)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteShort((short)fightTeamsOptions.Count());
            foreach (var entry in fightTeamsOptions)
            {
                 entry.Serialize(writer);
            }
        }
        
        public virtual void Deserialize(IReader reader)
        {
            fightId = reader.ReadInt();
            fightType = reader.ReadSByte();
            var limit = reader.ReadUShort();
            fightTeams = new Types.FightTeamInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (fightTeams as Types.FightTeamInformations[])[i] = ProtocolTypeManager.GetInstance<Types.FightTeamInformations>(reader.ReadUShort());
                 (fightTeams as Types.FightTeamInformations[])[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            fightTeamsPositions = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (fightTeamsPositions as ushort[])[i] = reader.ReadVarUhShort();
            }
            limit = reader.ReadUShort();
            fightTeamsOptions = new Types.FightOptionsInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (fightTeamsOptions as Types.FightOptionsInformations[])[i] = new Types.FightOptionsInformations();
                 (fightTeamsOptions as Types.FightOptionsInformations[])[i].Deserialize(reader);
            }
        }
        
    }
    
}