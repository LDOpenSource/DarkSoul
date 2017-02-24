

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
    public class ExchangeMountsTakenFromPaddockMessage : NetworkMessage
    {
        public override ushort Id => 6554;
        
        
        public string name;
        public short worldX;
        public short worldY;
        public string ownername;
        
        public ExchangeMountsTakenFromPaddockMessage()
        {
        }
        
        public ExchangeMountsTakenFromPaddockMessage(string name, short worldX, short worldY, string ownername)
        {
            this.name = name;
            this.worldX = worldX;
            this.worldY = worldY;
            this.ownername = ownername;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteUTF(name);
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            writer.WriteUTF(ownername);
        }
        
        public override void Deserialize(IReader reader)
        {
            name = reader.ReadUTF();
            worldX = reader.ReadShort();
            worldY = reader.ReadShort();
            ownername = reader.ReadUTF();
        }
        
    }
    
}