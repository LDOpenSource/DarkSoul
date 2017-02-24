

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
    public class GuildGetInformationsMessage : NetworkMessage
    {
        public override ushort Id => 5550;
        
        
        public sbyte infoType;
        
        public GuildGetInformationsMessage()
        {
        }
        
        public GuildGetInformationsMessage(sbyte infoType)
        {
            this.infoType = infoType;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(infoType);
        }
        
        public override void Deserialize(IReader reader)
        {
            infoType = reader.ReadSByte();
        }
        
    }
    
}