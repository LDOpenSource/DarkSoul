

// Generated on 02/23/2017 18:06:44
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class ObjectEffectDuration : ObjectEffect
    {
        public override short TypeId => 75;
        
        public ushort days;
        public sbyte hours;
        public sbyte minutes;
        
        public ObjectEffectDuration()
        {
        }
        
        public ObjectEffectDuration(ushort actionId, ushort days, sbyte hours, sbyte minutes)
         : base(actionId)
        {
            this.days = days;
            this.hours = hours;
            this.minutes = minutes;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((int)days);
            writer.WriteSByte(hours);
            writer.WriteSByte(minutes);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            days = reader.ReadVarUhShort();
            hours = reader.ReadSByte();
            minutes = reader.ReadSByte();
        }
        
    }
    
}