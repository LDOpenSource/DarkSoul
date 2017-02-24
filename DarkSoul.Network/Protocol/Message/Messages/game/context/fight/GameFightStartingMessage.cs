

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
    public class GameFightStartingMessage : NetworkMessage
    {
        public override ushort Id => 700;
        
        
        public sbyte fightType;
        public double attackerId;
        public double defenderId;
        
        public GameFightStartingMessage()
        {
        }
        
        public GameFightStartingMessage(sbyte fightType, double attackerId, double defenderId)
        {
            this.fightType = fightType;
            this.attackerId = attackerId;
            this.defenderId = defenderId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(fightType);
            writer.WriteDouble(attackerId);
            writer.WriteDouble(defenderId);
        }
        
        public override void Deserialize(IReader reader)
        {
            fightType = reader.ReadSByte();
            attackerId = reader.ReadDouble();
            defenderId = reader.ReadDouble();
        }
        
    }
    
}