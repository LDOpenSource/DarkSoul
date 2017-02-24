

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
    public class EmotePlayAbstractMessage : NetworkMessage
    {
        public override ushort Id => 5690;
        
        
        public byte emoteId;
        public double emoteStartTime;
        
        public EmotePlayAbstractMessage()
        {
        }
        
        public EmotePlayAbstractMessage(byte emoteId, double emoteStartTime)
        {
            this.emoteId = emoteId;
            this.emoteStartTime = emoteStartTime;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteByte(emoteId);
            writer.WriteDouble(emoteStartTime);
        }
        
        public override void Deserialize(IReader reader)
        {
            emoteId = reader.ReadByte();
            emoteStartTime = reader.ReadDouble();
        }
        
    }
    
}