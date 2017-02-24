

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
    public class PrismSettingsRequestMessage : NetworkMessage
    {
        public override ushort Id => 6437;
        
        
        public ushort subAreaId;
        public sbyte startDefenseTime;
        
        public PrismSettingsRequestMessage()
        {
        }
        
        public PrismSettingsRequestMessage(ushort subAreaId, sbyte startDefenseTime)
        {
            this.subAreaId = subAreaId;
            this.startDefenseTime = startDefenseTime;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)subAreaId);
            writer.WriteSByte(startDefenseTime);
        }
        
        public override void Deserialize(IReader reader)
        {
            subAreaId = reader.ReadVarUhShort();
            startDefenseTime = reader.ReadSByte();
        }
        
    }
    
}