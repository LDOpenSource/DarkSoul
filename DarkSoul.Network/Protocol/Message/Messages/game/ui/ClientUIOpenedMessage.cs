

// Generated on 02/23/2017 16:54:04
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ClientUIOpenedMessage : NetworkMessage
    {
        public override ushort Id => 6459;
        
        
        public sbyte type;
        
        public ClientUIOpenedMessage()
        {
        }
        
        public ClientUIOpenedMessage(sbyte type)
        {
            this.type = type;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(type);
        }
        
        public override void Deserialize(IReader reader)
        {
            type = reader.ReadSByte();
        }
        
    }
    
}