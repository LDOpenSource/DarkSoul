

// Generated on 02/23/2017 16:53:30
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameFightSpectatePlayerRequestMessage : NetworkMessage
    {
        public override ushort Id => 6474;
        
        
        public double playerId;
        
        public GameFightSpectatePlayerRequestMessage()
        {
        }
        
        public GameFightSpectatePlayerRequestMessage(double playerId)
        {
            this.playerId = playerId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarLong(playerId);
        }
        
        public override void Deserialize(IReader reader)
        {
            playerId = reader.ReadVarUhLong();
        }
        
    }
    
}