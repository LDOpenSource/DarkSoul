

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
    public class AccountLoggingKickedMessage : NetworkMessage
    {
        public override ushort Id => 6029;
        
        
        public ushort days;
        public sbyte hours;
        public sbyte minutes;
        
        public AccountLoggingKickedMessage()
        {
        }
        
        public AccountLoggingKickedMessage(ushort days, sbyte hours, sbyte minutes)
        {
            this.days = days;
            this.hours = hours;
            this.minutes = minutes;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)days);
            writer.WriteSByte(hours);
            writer.WriteSByte(minutes);
        }
        
        public override void Deserialize(IReader reader)
        {
            days = reader.ReadVarUhShort();
            hours = reader.ReadSByte();
            minutes = reader.ReadSByte();
        }
        
    }
    
}