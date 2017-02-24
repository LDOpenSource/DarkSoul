

// Generated on 02/23/2017 16:53:17
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class DebugInClientMessage : NetworkMessage
    {
        public override ushort Id => 6028;
        
        
        public sbyte level;
        public string message;
        
        public DebugInClientMessage()
        {
        }
        
        public DebugInClientMessage(sbyte level, string message)
        {
            this.level = level;
            this.message = message;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(level);
            writer.WriteUTF(message);
        }
        
        public override void Deserialize(IReader reader)
        {
            level = reader.ReadSByte();
            message = reader.ReadUTF();
        }
        
    }
    
}