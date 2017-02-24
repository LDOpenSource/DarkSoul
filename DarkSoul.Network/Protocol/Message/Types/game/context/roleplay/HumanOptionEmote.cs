

// Generated on 02/23/2017 18:06:42
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class HumanOptionEmote : HumanOption
    {
        public override short TypeId => 407;
        
        public byte emoteId;
        public double emoteStartTime;
        
        public HumanOptionEmote()
        {
        }
        
        public HumanOptionEmote(byte emoteId, double emoteStartTime)
        {
            this.emoteId = emoteId;
            this.emoteStartTime = emoteStartTime;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteByte(emoteId);
            writer.WriteDouble(emoteStartTime);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            emoteId = reader.ReadByte();
            emoteStartTime = reader.ReadDouble();
        }
        
    }
    
}