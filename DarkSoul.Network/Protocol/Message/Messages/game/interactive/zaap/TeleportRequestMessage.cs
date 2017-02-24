

// Generated on 02/23/2017 16:53:51
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class TeleportRequestMessage : NetworkMessage
    {
        public override ushort Id => 5961;
        
        
        public sbyte teleporterType;
        public int mapId;
        
        public TeleportRequestMessage()
        {
        }
        
        public TeleportRequestMessage(sbyte teleporterType, int mapId)
        {
            this.teleporterType = teleporterType;
            this.mapId = mapId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(teleporterType);
            writer.WriteInt(mapId);
        }
        
        public override void Deserialize(IReader reader)
        {
            teleporterType = reader.ReadSByte();
            mapId = reader.ReadInt();
        }
        
    }
    
}