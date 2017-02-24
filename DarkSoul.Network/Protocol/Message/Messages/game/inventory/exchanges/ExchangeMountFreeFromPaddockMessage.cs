

// Generated on 02/23/2017 16:53:53
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ExchangeMountFreeFromPaddockMessage : NetworkMessage
    {
        public override ushort Id => 6055;
        
        
        public string name;
        public short worldX;
        public short worldY;
        public string liberator;
        
        public ExchangeMountFreeFromPaddockMessage()
        {
        }
        
        public ExchangeMountFreeFromPaddockMessage(string name, short worldX, short worldY, string liberator)
        {
            this.name = name;
            this.worldX = worldX;
            this.worldY = worldY;
            this.liberator = liberator;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteUTF(name);
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            writer.WriteUTF(liberator);
        }
        
        public override void Deserialize(IReader reader)
        {
            name = reader.ReadUTF();
            worldX = reader.ReadShort();
            worldY = reader.ReadShort();
            liberator = reader.ReadUTF();
        }
        
    }
    
}