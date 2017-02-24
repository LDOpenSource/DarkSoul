

// Generated on 02/23/2017 16:53:38
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class LockableCodeResultMessage : NetworkMessage
    {
        public override ushort Id => 5672;
        
        
        public sbyte result;
        
        public LockableCodeResultMessage()
        {
        }
        
        public LockableCodeResultMessage(sbyte result)
        {
            this.result = result;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(result);
        }
        
        public override void Deserialize(IReader reader)
        {
            result = reader.ReadSByte();
        }
        
    }
    
}