

// Generated on 02/23/2017 16:53:22
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class AlmanachCalendarDateMessage : NetworkMessage
    {
        public override ushort Id => 6341;
        
        
        public int date;
        
        public AlmanachCalendarDateMessage()
        {
        }
        
        public AlmanachCalendarDateMessage(int date)
        {
            this.date = date;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteInt(date);
        }
        
        public override void Deserialize(IReader reader)
        {
            date = reader.ReadInt();
        }
        
    }
    
}