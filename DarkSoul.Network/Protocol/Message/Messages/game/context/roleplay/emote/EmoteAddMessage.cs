

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
    public class EmoteAddMessage : NetworkMessage
    {
        public override ushort Id => 5644;
        
        
        public byte emoteId;
        
        public EmoteAddMessage()
        {
        }
        
        public EmoteAddMessage(byte emoteId)
        {
            this.emoteId = emoteId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteByte(emoteId);
        }
        
        public override void Deserialize(IReader reader)
        {
            emoteId = reader.ReadByte();
        }
        
    }
    
}