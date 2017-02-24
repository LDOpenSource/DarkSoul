

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
    public class CurrentMapMessage : NetworkMessage
    {
        public override ushort Id => 220;
        
        
        public int mapId;
        public string mapKey;
        
        public CurrentMapMessage()
        {
        }
        
        public CurrentMapMessage(int mapId, string mapKey)
        {
            this.mapId = mapId;
            this.mapKey = mapKey;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteInt(mapId);
            writer.WriteUTF(mapKey);
        }
        
        public override void Deserialize(IReader reader)
        {
            mapId = reader.ReadInt();
            mapKey = reader.ReadUTF();
        }
        
    }
    
}