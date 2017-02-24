

// Generated on 02/23/2017 16:53:28
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameContextKickMessage : NetworkMessage
    {
        public override ushort Id => 6081;
        
        
        public double targetId;
        
        public GameContextKickMessage()
        {
        }
        
        public GameContextKickMessage(double targetId)
        {
            this.targetId = targetId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteDouble(targetId);
        }
        
        public override void Deserialize(IReader reader)
        {
            targetId = reader.ReadDouble();
        }
        
    }
    
}