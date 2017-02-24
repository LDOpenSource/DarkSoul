

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
    public class GameFightLeaveMessage : NetworkMessage
    {
        public override ushort Id => 721;
        
        
        public double charId;
        
        public GameFightLeaveMessage()
        {
        }
        
        public GameFightLeaveMessage(double charId)
        {
            this.charId = charId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteDouble(charId);
        }
        
        public override void Deserialize(IReader reader)
        {
            charId = reader.ReadDouble();
        }
        
    }
    
}