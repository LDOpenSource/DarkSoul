

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
    public class InventoryPresetDeleteMessage : NetworkMessage
    {
        public override ushort Id => 6169;
        
        
        public sbyte presetId;
        
        public InventoryPresetDeleteMessage()
        {
        }
        
        public InventoryPresetDeleteMessage(sbyte presetId)
        {
            this.presetId = presetId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(presetId);
        }
        
        public override void Deserialize(IReader reader)
        {
            presetId = reader.ReadSByte();
        }
        
    }
    
}