

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
    public class GetPartInfoMessage : NetworkMessage
    {
        public override ushort Id => 1506;
        
        
        public string id;
        
        public GetPartInfoMessage()
        {
        }
        
        public GetPartInfoMessage(string id)
        {
            this.id = id;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteUTF(id);
        }
        
        public override void Deserialize(IReader reader)
        {
            id = reader.ReadUTF();
        }
        
    }
    
}