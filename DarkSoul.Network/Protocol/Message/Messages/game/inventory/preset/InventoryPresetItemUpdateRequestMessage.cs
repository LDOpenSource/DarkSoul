

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
    public class InventoryPresetItemUpdateRequestMessage : NetworkMessage
    {
        public override ushort Id => 6210;
        
        
        public sbyte presetId;
        public byte position;
        public uint objUid;
        
        public InventoryPresetItemUpdateRequestMessage()
        {
        }
        
        public InventoryPresetItemUpdateRequestMessage(sbyte presetId, byte position, uint objUid)
        {
            this.presetId = presetId;
            this.position = position;
            this.objUid = objUid;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(presetId);
            writer.WriteByte(position);
            writer.WriteVarInt((int)objUid);
        }
        
        public override void Deserialize(IReader reader)
        {
            presetId = reader.ReadSByte();
            position = reader.ReadByte();
            objUid = reader.ReadVarUhInt();
        }
        
    }
    
}