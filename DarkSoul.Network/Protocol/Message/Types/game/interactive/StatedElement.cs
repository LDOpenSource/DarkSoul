

// Generated on 02/23/2017 18:06:45
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class StatedElement
    {
        public virtual short TypeId => 108;
        
        public int elementId;
        public ushort elementCellId;
        public uint elementState;
        public bool onCurrentMap;
        
        public StatedElement()
        {
        }
        
        public StatedElement(int elementId, ushort elementCellId, uint elementState, bool onCurrentMap)
        {
            this.elementId = elementId;
            this.elementCellId = elementCellId;
            this.elementState = elementState;
            this.onCurrentMap = onCurrentMap;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteInt(elementId);
            writer.WriteVarShort((int)elementCellId);
            writer.WriteVarInt((int)elementState);
            writer.WriteBoolean(onCurrentMap);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            elementId = reader.ReadInt();
            elementCellId = reader.ReadVarUhShort();
            elementState = reader.ReadVarUhInt();
            onCurrentMap = reader.ReadBoolean();
        }
        
    }
    
}