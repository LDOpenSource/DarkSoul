

// Generated on 02/23/2017 16:53:45
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class DareErrorMessage : NetworkMessage
    {
        public override ushort Id => 6667;
        
        
        public sbyte error;
        
        public DareErrorMessage()
        {
        }
        
        public DareErrorMessage(sbyte error)
        {
            this.error = error;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(error);
        }
        
        public override void Deserialize(IReader reader)
        {
            error = reader.ReadSByte();
        }
        
    }
    
}