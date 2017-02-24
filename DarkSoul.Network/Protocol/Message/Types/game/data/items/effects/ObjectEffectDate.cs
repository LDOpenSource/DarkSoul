

// Generated on 02/23/2017 18:06:44
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class ObjectEffectDate : ObjectEffect
    {
        public override short TypeId => 72;
        
        public ushort year;
        public sbyte month;
        public sbyte day;
        public sbyte hour;
        public sbyte minute;
        
        public ObjectEffectDate()
        {
        }
        
        public ObjectEffectDate(ushort actionId, ushort year, sbyte month, sbyte day, sbyte hour, sbyte minute)
         : base(actionId)
        {
            this.year = year;
            this.month = month;
            this.day = day;
            this.hour = hour;
            this.minute = minute;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((int)year);
            writer.WriteSByte(month);
            writer.WriteSByte(day);
            writer.WriteSByte(hour);
            writer.WriteSByte(minute);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            year = reader.ReadVarUhShort();
            month = reader.ReadSByte();
            day = reader.ReadSByte();
            hour = reader.ReadSByte();
            minute = reader.ReadSByte();
        }
        
    }
    
}