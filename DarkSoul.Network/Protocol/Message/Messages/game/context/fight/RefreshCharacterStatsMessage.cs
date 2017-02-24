

// Generated on 02/23/2017 16:53:31
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class RefreshCharacterStatsMessage : NetworkMessage
    {
        public override ushort Id => 6699;
        
        
        public double fighterId;
        public Types.GameFightMinimalStats stats;
        
        public RefreshCharacterStatsMessage()
        {
        }
        
        public RefreshCharacterStatsMessage(double fighterId, Types.GameFightMinimalStats stats)
        {
            this.fighterId = fighterId;
            this.stats = stats;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteDouble(fighterId);
            stats.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            fighterId = reader.ReadDouble();
            stats = new Types.GameFightMinimalStats();
            stats.Deserialize(reader);
        }
        
    }
    
}