

// Generated on 02/23/2017 18:06:39
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class FightExternalInformations
    {
        public virtual short TypeId => 117;
        
        public int fightId;
        public sbyte fightType;
        public int fightStart;
        public bool fightSpectatorLocked;
        public IEnumerable<Types.FightTeamLightInformations> fightTeams;
        public IEnumerable<Types.FightOptionsInformations> fightTeamsOptions;
        
        public FightExternalInformations()
        {
        }
        
        public FightExternalInformations(int fightId, sbyte fightType, int fightStart, bool fightSpectatorLocked, IEnumerable<Types.FightTeamLightInformations> fightTeams, IEnumerable<Types.FightOptionsInformations> fightTeamsOptions)
        {
            this.fightId = fightId;
            this.fightType = fightType;
            this.fightStart = fightStart;
            this.fightSpectatorLocked = fightSpectatorLocked;
            this.fightTeams = fightTeams;
            this.fightTeamsOptions = fightTeamsOptions;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteInt(fightId);
            writer.WriteSByte(fightType);
            writer.WriteInt(fightStart);
            writer.WriteBoolean(fightSpectatorLocked);
            foreach (var entry in fightTeams)
            {
                 entry.Serialize(writer);
            }
            foreach (var entry in fightTeamsOptions)
            {
                 entry.Serialize(writer);
            }
        }
        
        public virtual void Deserialize(IReader reader)
        {
            fightId = reader.ReadInt();
            fightType = reader.ReadSByte();
            fightStart = reader.ReadInt();
            fightSpectatorLocked = reader.ReadBoolean();
            fightTeams = new Types.FightTeamLightInformations[2];
            for (int i = 0; i < 2; i++)
            {
                 (fightTeams as Types.FightTeamLightInformations[])[i] = new Types.FightTeamLightInformations();
                 (fightTeams as Types.FightTeamLightInformations[])[i].Deserialize(reader);
            }
            fightTeamsOptions = new Types.FightOptionsInformations[2];
            for (int i = 0; i < 2; i++)
            {
                 (fightTeamsOptions as Types.FightOptionsInformations[])[i] = new Types.FightOptionsInformations();
                 (fightTeamsOptions as Types.FightOptionsInformations[])[i].Deserialize(reader);
            }
        }
        
    }
    
}