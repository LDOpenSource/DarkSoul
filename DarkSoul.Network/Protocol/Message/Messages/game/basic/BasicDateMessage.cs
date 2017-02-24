

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
    public class BasicDateMessage : NetworkMessage
    {
        public override ushort Id => 177;
        
        
        public sbyte day;
        public sbyte month;
        public short year;
        
        public BasicDateMessage()
        {
        }
        
        public BasicDateMessage(sbyte day, sbyte month, short year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(day);
            writer.WriteSByte(month);
            writer.WriteShort(year);
        }
        
        public override void Deserialize(IReader reader)
        {
            day = reader.ReadSByte();
            month = reader.ReadSByte();
            year = reader.ReadShort();
        }
        
    }
    
}