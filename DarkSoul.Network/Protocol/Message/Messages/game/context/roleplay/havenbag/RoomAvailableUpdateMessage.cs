

// Generated on 02/23/2017 16:53:36
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class RoomAvailableUpdateMessage : NetworkMessage
    {
        public override ushort Id => 6630;
        
        
        public byte nbRoom;
        
        public RoomAvailableUpdateMessage()
        {
        }
        
        public RoomAvailableUpdateMessage(byte nbRoom)
        {
            this.nbRoom = nbRoom;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteByte(nbRoom);
        }
        
        public override void Deserialize(IReader reader)
        {
            nbRoom = reader.ReadByte();
        }
        
    }
    
}