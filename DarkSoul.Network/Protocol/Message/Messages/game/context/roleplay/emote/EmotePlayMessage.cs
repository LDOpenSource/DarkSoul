

// Generated on 02/23/2017 16:53:35
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class EmotePlayMessage : EmotePlayAbstractMessage
    {
        public override ushort Id => 5683;
        
        
        public double actorId;
        public int accountId;
        
        public EmotePlayMessage()
        {
        }
        
        public EmotePlayMessage(byte emoteId, double emoteStartTime, double actorId, int accountId)
         : base(emoteId, emoteStartTime)
        {
            this.actorId = actorId;
            this.accountId = accountId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(actorId);
            writer.WriteInt(accountId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            actorId = reader.ReadDouble();
            accountId = reader.ReadInt();
        }
        
    }
    
}