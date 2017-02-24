

// Generated on 02/23/2017 16:53:23
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class CompassResetMessage : NetworkMessage
    {
        public override ushort Id => 5584;
        
        
        public sbyte type;
        
        public CompassResetMessage()
        {
        }
        
        public CompassResetMessage(sbyte type)
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