

// Generated on 02/23/2017 16:53:33
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ErrorMapNotFoundMessage : NetworkMessage
    {
        public override ushort Id => 6197;
        
        
        public int mapId;
        
        public ErrorMapNotFoundMessage()
        {
        }
        
        public ErrorMapNotFoundMessage(int mapId)
        {
            this.mapId = mapId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteInt(mapId);
        }
        
        public override void Deserialize(IReader reader)
        {
            mapId = reader.ReadInt();
        }
        
    }
    
}