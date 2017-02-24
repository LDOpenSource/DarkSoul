

// Generated on 02/23/2017 16:54:02
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class CharacterReportMessage : NetworkMessage
    {
        public override ushort Id => 6079;
        
        
        public double reportedId;
        public sbyte reason;
        
        public CharacterReportMessage()
        {
        }
        
        public CharacterReportMessage(double reportedId, sbyte reason)
        {
            this.reportedId = reportedId;
            this.reason = reason;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarLong(reportedId);
            writer.WriteSByte(reason);
        }
        
        public override void Deserialize(IReader reader)
        {
            reportedId = reader.ReadVarUhLong();
            reason = reader.ReadSByte();
        }
        
    }
    
}