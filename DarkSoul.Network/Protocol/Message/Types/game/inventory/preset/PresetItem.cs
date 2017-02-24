

// Generated on 02/23/2017 18:06:46
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class PresetItem
    {
        public virtual short TypeId => 354;
        
        public byte position;
        public ushort objGid;
        public uint objUid;
        
        public PresetItem()
        {
        }
        
        public PresetItem(byte position, ushort objGid, uint objUid)
        {
            this.position = position;
            this.objGid = objGid;
            this.objUid = objUid;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteByte(position);
            writer.WriteVarShort((int)objGid);
            writer.WriteVarInt((int)objUid);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            position = reader.ReadByte();
            objGid = reader.ReadVarUhShort();
            objUid = reader.ReadVarUhInt();
        }
        
    }
    
}