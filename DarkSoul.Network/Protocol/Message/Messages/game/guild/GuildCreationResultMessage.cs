

// Generated on 02/23/2017 16:53:47
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GuildCreationResultMessage : NetworkMessage
    {
        public override ushort Id => 5554;
        
        
        public sbyte result;
        
        public GuildCreationResultMessage()
        {
        }
        
        public GuildCreationResultMessage(sbyte result)
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