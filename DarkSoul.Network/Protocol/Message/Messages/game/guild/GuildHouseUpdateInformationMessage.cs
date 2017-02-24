

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
    public class GuildHouseUpdateInformationMessage : NetworkMessage
    {
        public override ushort Id => 6181;
        
        
        public Types.HouseInformationsForGuild housesInformations;
        
        public GuildHouseUpdateInformationMessage()
        {
        }
        
        public GuildHouseUpdateInformationMessage(Types.HouseInformationsForGuild housesInformations)
        {
            this.housesInformations = housesInformations;
        }
        
        public override void Serialize(IWriter writer)
        {
            housesInformations.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            housesInformations = new Types.HouseInformationsForGuild();
            housesInformations.Deserialize(reader);
        }
        
    }
    
}