

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
    public class InventoryPresetItemUpdateMessage : NetworkMessage
    {
        public override ushort Id => 0x1818;
        
        
        public sbyte presetId;
        public Types.PresetItem presetItem;
        
        public InventoryPresetItemUpdateMessage()
        {
        }
        
        public InventoryPresetItemUpdateMessage(sbyte presetId, Types.PresetItem presetItem)
        {
            this.presetId = presetId;
            this.presetItem = presetItem;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(presetId);
            presetItem.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            presetId = reader.ReadSByte();
            presetItem = new Types.PresetItem();
            presetItem.Deserialize(reader);
        }
        
    }
    
}