

// Generated on 02/23/2017 16:54:00
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class InventoryPresetDeleteResultMessage : NetworkMessage
    {
        public override ushort Id => 6173;
        
        
        public sbyte presetId;
        public sbyte code;
        
        public InventoryPresetDeleteResultMessage()
        {
        }
        
        public InventoryPresetDeleteResultMessage(sbyte presetId, sbyte code)
        {
            this.presetId = presetId;
            this.code = code;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(presetId);
            writer.WriteSByte(code);
        }
        
        public override void Deserialize(IReader reader)
        {
            presetId = reader.ReadSByte();
            code = reader.ReadSByte();
        }
        
    }
    
}