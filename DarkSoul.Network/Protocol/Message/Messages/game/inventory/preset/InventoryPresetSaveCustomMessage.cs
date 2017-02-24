

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
    public class InventoryPresetSaveCustomMessage : NetworkMessage
    {
        public override ushort Id => 6329;
        
        
        public sbyte presetId;
        public sbyte symbolId;
        public IEnumerable<byte> itemsPositions;
        public IEnumerable<uint> itemsUids;
        
        public InventoryPresetSaveCustomMessage()
        {
        }
        
        public InventoryPresetSaveCustomMessage(sbyte presetId, sbyte symbolId, IEnumerable<byte> itemsPositions, IEnumerable<uint> itemsUids)
        {
            this.presetId = presetId;
            this.symbolId = symbolId;
            this.itemsPositions = itemsPositions;
            this.itemsUids = itemsUids;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(presetId);
            writer.WriteSByte(symbolId);
            writer.WriteShort((short)itemsPositions.Count());
            foreach (var entry in itemsPositions)
            {
                 writer.WriteByte(entry);
            }
            writer.WriteShort((short)itemsUids.Count());
            foreach (var entry in itemsUids)
            {
                 writer.WriteVarInt((int)entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            presetId = reader.ReadSByte();
            symbolId = reader.ReadSByte();
            var limit = reader.ReadUShort();
            itemsPositions = new byte[limit];
            for (int i = 0; i < limit; i++)
            {
                 (itemsPositions as byte[])[i] = reader.ReadByte();
            }
            limit = reader.ReadUShort();
            itemsUids = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 (itemsUids as uint[])[i] = reader.ReadVarUhInt();
            }
        }
        
    }
    
}