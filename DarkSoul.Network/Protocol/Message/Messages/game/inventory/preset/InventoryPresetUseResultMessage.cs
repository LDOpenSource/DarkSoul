

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
    public class InventoryPresetUseResultMessage : NetworkMessage
    {
        public override ushort Id => 6163;
        
        
        public sbyte presetId;
        public sbyte code;
        public IEnumerable<byte> unlinkedPosition;
        
        public InventoryPresetUseResultMessage()
        {
        }
        
        public InventoryPresetUseResultMessage(sbyte presetId, sbyte code, IEnumerable<byte> unlinkedPosition)
        {
            this.presetId = presetId;
            this.code = code;
            this.unlinkedPosition = unlinkedPosition;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(presetId);
            writer.WriteSByte(code);
            writer.WriteShort((short)unlinkedPosition.Count());
            foreach (var entry in unlinkedPosition)
            {
                 writer.WriteByte(entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            presetId = reader.ReadSByte();
            code = reader.ReadSByte();
            var limit = reader.ReadUShort();
            unlinkedPosition = new byte[limit];
            for (int i = 0; i < limit; i++)
            {
                 (unlinkedPosition as byte[])[i] = reader.ReadByte();
            }
        }
        
    }
    
}