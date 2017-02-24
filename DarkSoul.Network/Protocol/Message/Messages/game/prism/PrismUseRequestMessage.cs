

// Generated on 02/23/2017 16:54:02
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class PrismUseRequestMessage : NetworkMessage
    {
        public override ushort Id => 6041;
        
        
        public sbyte moduleToUse;
        
        public PrismUseRequestMessage()
        {
        }
        
        public PrismUseRequestMessage(sbyte moduleToUse)
        {
            this.moduleToUse = moduleToUse;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(moduleToUse);
        }
        
        public override void Deserialize(IReader reader)
        {
            moduleToUse = reader.ReadSByte();
        }
        
    }
    
}