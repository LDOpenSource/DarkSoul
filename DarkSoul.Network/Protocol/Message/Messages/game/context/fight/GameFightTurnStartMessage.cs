

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
    public class GameFightTurnStartMessage : NetworkMessage
    {
        public override ushort Id => 714;
        
        
        public double id;
        public uint waitTime;
        
        public GameFightTurnStartMessage()
        {
        }
        
        public GameFightTurnStartMessage(double id, uint waitTime)
        {
            this.id = id;
            this.waitTime = waitTime;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteDouble(id);
            writer.WriteVarInt((int)waitTime);
        }
        
        public override void Deserialize(IReader reader)
        {
            id = reader.ReadDouble();
            waitTime = reader.ReadVarUhInt();
        }
        
    }
    
}