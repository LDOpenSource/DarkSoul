

// Generated on 02/23/2017 16:53:34
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class MapInformationsRequestMessage : NetworkMessage
    {
        public override ushort Id => 225;
        
        
        public int mapId;
        
        public MapInformationsRequestMessage()
        {
        }
        
        public MapInformationsRequestMessage(int mapId)
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