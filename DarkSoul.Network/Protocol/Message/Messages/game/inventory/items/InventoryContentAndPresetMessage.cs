

// Generated on 02/23/2017 16:53:57
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class InventoryContentAndPresetMessage : InventoryContentMessage
    {
        public override ushort Id => 6162;
        
        
        public IEnumerable<Types.Preset> presets;
        public IEnumerable<Types.IdolsPreset> idolsPresets;
        
        public InventoryContentAndPresetMessage()
        {
        }
        
        public InventoryContentAndPresetMessage(IEnumerable<Types.ObjectItem> objects, double kamas, IEnumerable<Types.Preset> presets, IEnumerable<Types.IdolsPreset> idolsPresets)
         : base(objects, kamas)
        {
            this.presets = presets;
            this.idolsPresets = idolsPresets;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort((short)presets.Count());
            foreach (var entry in presets)
            {
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)idolsPresets.Count());
            foreach (var entry in idolsPresets)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            var limit = reader.ReadUShort();
            presets = new Types.Preset[limit];
            for (int i = 0; i < limit; i++)
            {
                 (presets as Types.Preset[])[i] = new Types.Preset();
                 (presets as Types.Preset[])[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            idolsPresets = new Types.IdolsPreset[limit];
            for (int i = 0; i < limit; i++)
            {
                 (idolsPresets as Types.IdolsPreset[])[i] = new Types.IdolsPreset();
                 (idolsPresets as Types.IdolsPreset[])[i].Deserialize(reader);
            }
        }
        
    }
    
}