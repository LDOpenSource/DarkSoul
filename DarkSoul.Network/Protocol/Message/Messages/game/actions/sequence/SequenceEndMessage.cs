

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
    public class SequenceEndMessage : NetworkMessage
    {
        public override ushort Id => 956;
        
        
        public ushort actionId;
        public double authorId;
        public sbyte sequenceType;
        
        public SequenceEndMessage()
        {
        }
        
        public SequenceEndMessage(ushort actionId, double authorId, sbyte sequenceType)
        {
            this.actionId = actionId;
            this.authorId = authorId;
            this.sequenceType = sequenceType;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)actionId);
            writer.WriteDouble(authorId);
            writer.WriteSByte(sequenceType);
        }
        
        public override void Deserialize(IReader reader)
        {
            actionId = reader.ReadVarUhShort();
            authorId = reader.ReadDouble();
            sequenceType = reader.ReadSByte();
        }
        
    }
    
}