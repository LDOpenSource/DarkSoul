

// Generated on 02/23/2017 16:53:21
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class SequenceStartMessage : NetworkMessage
    {
        public override ushort Id => 955;
        
        
        public sbyte sequenceType;
        public double authorId;
        
        public SequenceStartMessage()
        {
        }
        
        public SequenceStartMessage(sbyte sequenceType, double authorId)
        {
            this.sequenceType = sequenceType;
            this.authorId = authorId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(sequenceType);
            writer.WriteDouble(authorId);
        }
        
        public override void Deserialize(IReader reader)
        {
            sequenceType = reader.ReadSByte();
            authorId = reader.ReadDouble();
        }
        
    }
    
}