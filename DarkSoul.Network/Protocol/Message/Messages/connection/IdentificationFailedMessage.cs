

// Generated on 02/23/2017 16:53:16
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class IdentificationFailedMessage : NetworkMessage
    {
        public override ushort Id => 20;
        
        
        public sbyte reason;
        
        public IdentificationFailedMessage()
        {
        }
        
        public IdentificationFailedMessage(sbyte reason)
        {
            this.reason = reason;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(reason);
        }
        
        public override void Deserialize(IReader reader)
        {
            reason = reader.ReadSByte();
        }
        
    }
    
}