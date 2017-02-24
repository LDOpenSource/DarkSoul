

// Generated on 02/23/2017 18:06:46
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class Preset
    {
        public virtual short TypeId => 355;
        
        public sbyte presetId;
        public sbyte symbolId;
        public bool mount;
        public IEnumerable<Types.PresetItem> objects;
        
        public Preset()
        {
        }
        
        public Preset(sbyte presetId, sbyte symbolId, bool mount, IEnumerable<Types.PresetItem> objects)
        {
            this.presetId = presetId;
            this.symbolId = symbolId;
            this.mount = mount;
            this.objects = objects;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteSByte(presetId);
            writer.WriteSByte(symbolId);
            writer.WriteBoolean(mount);
            writer.WriteShort((short)objects.Count());
            foreach (var entry in objects)
            {
                 entry.Serialize(writer);
            }
        }
        
        public virtual void Deserialize(IReader reader)
        {
            presetId = reader.ReadSByte();
            symbolId = reader.ReadSByte();
            mount = reader.ReadBoolean();
            var limit = reader.ReadUShort();
            objects = new Types.PresetItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 (objects as Types.PresetItem[])[i] = new Types.PresetItem();
                 (objects as Types.PresetItem[])[i].Deserialize(reader);
            }
        }
        
    }
    
}