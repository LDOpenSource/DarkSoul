

// Generated on 02/23/2017 16:53:29
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameFightEndMessage : NetworkMessage
    {
        public override ushort Id => 720;
        
        
        public int duration;
        public short ageBonus;
        public short lootShareLimitMalus;
        public IEnumerable<Types.FightResultListEntry> results;
        public IEnumerable<Types.NamedPartyTeamWithOutcome> namedPartyTeamsOutcomes;
        
        public GameFightEndMessage()
        {
        }
        
        public GameFightEndMessage(int duration, short ageBonus, short lootShareLimitMalus, IEnumerable<Types.FightResultListEntry> results, IEnumerable<Types.NamedPartyTeamWithOutcome> namedPartyTeamsOutcomes)
        {
            this.duration = duration;
            this.ageBonus = ageBonus;
            this.lootShareLimitMalus = lootShareLimitMalus;
            this.results = results;
            this.namedPartyTeamsOutcomes = namedPartyTeamsOutcomes;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteInt(duration);
            writer.WriteShort(ageBonus);
            writer.WriteShort(lootShareLimitMalus);
            writer.WriteShort((short)results.Count());
            foreach (var entry in results)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)namedPartyTeamsOutcomes.Count());
            foreach (var entry in namedPartyTeamsOutcomes)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            duration = reader.ReadInt();
            ageBonus = reader.ReadShort();
            lootShareLimitMalus = reader.ReadShort();
            var limit = reader.ReadUShort();
            results = new Types.FightResultListEntry[limit];
            for (int i = 0; i < limit; i++)
            {
                 (results as Types.FightResultListEntry[])[i] = ProtocolTypeManager.GetInstance<Types.FightResultListEntry>(reader.ReadUShort());
                 (results as Types.FightResultListEntry[])[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            namedPartyTeamsOutcomes = new Types.NamedPartyTeamWithOutcome[limit];
            for (int i = 0; i < limit; i++)
            {
                 (namedPartyTeamsOutcomes as Types.NamedPartyTeamWithOutcome[])[i] = new Types.NamedPartyTeamWithOutcome();
                 (namedPartyTeamsOutcomes as Types.NamedPartyTeamWithOutcome[])[i].Deserialize(reader);
            }
        }
        
    }
    
}