

// Generated on 02/23/2017 16:53:26
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class CharacterStatsListMessage : NetworkMessage
    {
        public override ushort Id => 500;
        
        
        public Types.CharacterCharacteristicsInformations stats;
        
        public CharacterStatsListMessage()
        {
        }
        
        public CharacterStatsListMessage(Types.CharacterCharacteristicsInformations stats)
        {
            this.stats = stats;
        }
        
        public override void Serialize(IWriter writer)
        {
            stats.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            stats = new Types.CharacterCharacteristicsInformations();
            stats.Deserialize(reader);
        }
        
    }
    
}