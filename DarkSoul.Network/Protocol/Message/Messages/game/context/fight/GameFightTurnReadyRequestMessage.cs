

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
    public class GameFightTurnReadyRequestMessage : NetworkMessage
    {
        public override ushort Id => 715;
        
        
        public double id;
        
        public GameFightTurnReadyRequestMessage()
        {
        }
        
        public GameFightTurnReadyRequestMessage(double id)
        {
            this.id = id;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteDouble(id);
        }
        
        public override void Deserialize(IReader reader)
        {
            id = reader.ReadDouble();
        }
        
    }
    
}