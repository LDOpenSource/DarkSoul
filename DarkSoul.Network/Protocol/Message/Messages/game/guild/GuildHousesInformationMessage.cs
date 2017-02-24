

// Generated on 02/23/2017 16:53:47
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GuildHousesInformationMessage : NetworkMessage
    {
        public override ushort Id => 5919;
        
        
        public IEnumerable<Types.HouseInformationsForGuild> housesInformations;
        
        public GuildHousesInformationMessage()
        {
        }
        
        public GuildHousesInformationMessage(IEnumerable<Types.HouseInformationsForGuild> housesInformations)
        {
            this.housesInformations = housesInformations;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)housesInformations.Count());
            foreach (var entry in housesInformations)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            housesInformations = new Types.HouseInformationsForGuild[limit];
            for (int i = 0; i < limit; i++)
            {
                 (housesInformations as Types.HouseInformationsForGuild[])[i] = new Types.HouseInformationsForGuild();
                 (housesInformations as Types.HouseInformationsForGuild[])[i].Deserialize(reader);
            }
        }
        
    }
    
}