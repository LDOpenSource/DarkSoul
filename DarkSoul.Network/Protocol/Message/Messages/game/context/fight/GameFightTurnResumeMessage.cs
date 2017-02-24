

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
    public class GameFightTurnResumeMessage : GameFightTurnStartMessage
    {
        public override ushort Id => 6307;
        
        
        public uint remainingTime;
        
        public GameFightTurnResumeMessage()
        {
        }
        
        public GameFightTurnResumeMessage(double id, uint waitTime, uint remainingTime)
         : base(id, waitTime)
        {
            this.remainingTime = remainingTime;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt((int)remainingTime);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            remainingTime = reader.ReadVarUhInt();
        }
        
    }
    
}