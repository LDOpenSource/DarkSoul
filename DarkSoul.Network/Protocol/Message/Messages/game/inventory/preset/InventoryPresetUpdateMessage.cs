

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
    public class InventoryPresetUpdateMessage : NetworkMessage
    {
        public override ushort Id => 6171;
        
        
        public Types.Preset preset;
        
        public InventoryPresetUpdateMessage()
        {
        }
        
        public InventoryPresetUpdateMessage(Types.Preset preset)
        {
            this.preset = preset;
        }
        
        public override void Serialize(IWriter writer)
        {
            preset.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            preset = new Types.Preset();
            preset.Deserialize(reader);
        }
        
    }
    
}