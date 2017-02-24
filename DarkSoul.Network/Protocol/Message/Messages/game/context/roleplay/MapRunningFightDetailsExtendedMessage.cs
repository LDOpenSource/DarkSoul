

// Generated on 02/23/2017 16:53:34
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class MapRunningFightDetailsExtendedMessage : MapRunningFightDetailsMessage
    {
        public override ushort Id => 6500;
        
        
        public IEnumerable<Types.NamedPartyTeam> namedPartyTeams;
        
        public MapRunningFightDetailsExtendedMessage()
        {
        }
        
        public MapRunningFightDetailsExtendedMessage(int fightId, IEnumerable<Types.GameFightFighterLightInformations> attackers, IEnumerable<Types.GameFightFighterLightInformations> defenders, IEnumerable<Types.NamedPartyTeam> namedPartyTeams)
         : base(fightId, attackers, defenders)
        {
            this.namedPartyTeams = namedPartyTeams;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort((short)namedPartyTeams.Count());
            foreach (var entry in namedPartyTeams)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            var limit = reader.ReadUShort();
            namedPartyTeams = new Types.NamedPartyTeam[limit];
            for (int i = 0; i < limit; i++)
            {
                 (namedPartyTeams as Types.NamedPartyTeam[])[i] = new Types.NamedPartyTeam();
                 (namedPartyTeams as Types.NamedPartyTeam[])[i].Deserialize(reader);
            }
        }
        
    }
    
}