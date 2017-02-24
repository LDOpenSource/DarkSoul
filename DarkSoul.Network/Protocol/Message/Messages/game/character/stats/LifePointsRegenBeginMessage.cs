

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
    public class LifePointsRegenBeginMessage : NetworkMessage
    {
        public override ushort Id => 5684;
        
        
        public byte regenRate;
        
        public LifePointsRegenBeginMessage()
        {
        }
        
        public LifePointsRegenBeginMessage(byte regenRate)
        {
            this.regenRate = regenRate;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteByte(regenRate);
        }
        
        public override void Deserialize(IReader reader)
        {
            regenRate = reader.ReadByte();
        }
        
    }
    
}