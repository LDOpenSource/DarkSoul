

// Generated on 02/23/2017 16:54:01
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class PrismSetSabotagedRefusedMessage : NetworkMessage
    {
        public override ushort Id => 6466;
        
        
        public ushort subAreaId;
        public sbyte reason;
        
        public PrismSetSabotagedRefusedMessage()
        {
        }
        
        public PrismSetSabotagedRefusedMessage(ushort subAreaId, sbyte reason)
        {
            this.subAreaId = subAreaId;
            this.reason = reason;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)subAreaId);
            writer.WriteSByte(reason);
        }
        
        public override void Deserialize(IReader reader)
        {
            subAreaId = reader.ReadVarUhShort();
            reason = reader.ReadSByte();
        }
        
    }
    
}