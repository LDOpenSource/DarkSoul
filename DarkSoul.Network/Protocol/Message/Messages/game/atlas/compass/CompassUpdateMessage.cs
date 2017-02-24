

// Generated on 02/23/2017 16:53:23
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class CompassUpdateMessage : NetworkMessage
    {
        public override ushort Id => 5591;
        
        
        public sbyte type;
        public Types.MapCoordinates coords;
        
        public CompassUpdateMessage()
        {
        }
        
        public CompassUpdateMessage(sbyte type, Types.MapCoordinates coords)
        {
            this.type = type;
            this.coords = coords;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(type);
            writer.WriteShort(coords.TypeId);
            coords.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            type = reader.ReadSByte();
            coords = ProtocolTypeManager.GetInstance<Types.MapCoordinates>(reader.ReadUShort());
            coords.Deserialize(reader);
        }
        
    }
    
}