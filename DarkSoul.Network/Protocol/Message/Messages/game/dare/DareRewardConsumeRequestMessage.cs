

// Generated on 02/23/2017 16:53:45
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class DareRewardConsumeRequestMessage : NetworkMessage
    {
        public override ushort Id => 6676;
        
        
        public double dareId;
        public sbyte type;
        
        public DareRewardConsumeRequestMessage()
        {
        }
        
        public DareRewardConsumeRequestMessage(double dareId, sbyte type)
        {
            this.dareId = dareId;
            this.type = type;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteDouble(dareId);
            writer.WriteSByte(type);
        }
        
        public override void Deserialize(IReader reader)
        {
            dareId = reader.ReadDouble();
            type = reader.ReadSByte();
        }
        
    }
    
}