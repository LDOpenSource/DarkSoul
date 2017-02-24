

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
    public class BasicLatencyStatsMessage : NetworkMessage
    {
        public override ushort Id => 5663;
        
        
        public ushort latency;
        public ushort sampleCount;
        public ushort max;
        
        public BasicLatencyStatsMessage()
        {
        }
        
        public BasicLatencyStatsMessage(ushort latency, ushort sampleCount, ushort max)
        {
            this.latency = latency;
            this.sampleCount = sampleCount;
            this.max = max;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteUShort(latency);
            writer.WriteVarShort((int)sampleCount);
            writer.WriteVarShort((int)max);
        }
        
        public override void Deserialize(IReader reader)
        {
            latency = reader.ReadUShort();
            sampleCount = reader.ReadVarUhShort();
            max = reader.ReadVarUhShort();
        }
        
    }
    
}