

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
    public class URLOpenMessage : NetworkMessage
    {
        public override ushort Id => 6266;
        
        
        public sbyte urlId;
        
        public URLOpenMessage()
        {
        }
        
        public URLOpenMessage(sbyte urlId)
        {
            this.urlId = urlId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(urlId);
        }
        
        public override void Deserialize(IReader reader)
        {
            urlId = reader.ReadSByte();
        }
        
    }
    
}