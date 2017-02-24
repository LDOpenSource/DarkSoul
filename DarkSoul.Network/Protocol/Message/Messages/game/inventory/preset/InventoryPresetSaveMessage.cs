

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
    public class InventoryPresetSaveMessage : NetworkMessage
    {
        public override ushort Id => 6165;
        
        
        public sbyte presetId;
        public sbyte symbolId;
        public bool saveEquipment;
        
        public InventoryPresetSaveMessage()
        {
        }
        
        public InventoryPresetSaveMessage(sbyte presetId, sbyte symbolId, bool saveEquipment)
        {
            this.presetId = presetId;
            this.symbolId = symbolId;
            this.saveEquipment = saveEquipment;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(presetId);
            writer.WriteSByte(symbolId);
            writer.WriteBoolean(saveEquipment);
        }
        
        public override void Deserialize(IReader reader)
        {
            presetId = reader.ReadSByte();
            symbolId = reader.ReadSByte();
            saveEquipment = reader.ReadBoolean();
        }
        
    }
    
}