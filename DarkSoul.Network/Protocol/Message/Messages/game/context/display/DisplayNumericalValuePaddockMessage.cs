

// Generated on 02/23/2017 16:53:29
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class DisplayNumericalValuePaddockMessage : NetworkMessage
    {
        public override ushort Id => 6563;
        
        
        public int rideId;
        public int value;
        public sbyte type;
        
        public DisplayNumericalValuePaddockMessage()
        {
        }
        
        public DisplayNumericalValuePaddockMessage(int rideId, int value, sbyte type)
        {
            this.rideId = rideId;
            this.value = value;
            this.type = type;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteInt(rideId);
            writer.WriteInt(value);
            writer.WriteSByte(type);
        }
        
        public override void Deserialize(IReader reader)
        {
            rideId = reader.ReadInt();
            value = reader.ReadInt();
            type = reader.ReadSByte();
        }
        
    }
    
}