

// Generated on 02/23/2017 18:06:45
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class GuildEmblem
    {
        public virtual short TypeId => 87;
        
        public ushort symbolShape;
        public int symbolColor;
        public sbyte backgroundShape;
        public int backgroundColor;
        
        public GuildEmblem()
        {
        }
        
        public GuildEmblem(ushort symbolShape, int symbolColor, sbyte backgroundShape, int backgroundColor)
        {
            this.symbolShape = symbolShape;
            this.symbolColor = symbolColor;
            this.backgroundShape = backgroundShape;
            this.backgroundColor = backgroundColor;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)symbolShape);
            writer.WriteInt(symbolColor);
            writer.WriteSByte(backgroundShape);
            writer.WriteInt(backgroundColor);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            symbolShape = reader.ReadVarUhShort();
            symbolColor = reader.ReadInt();
            backgroundShape = reader.ReadSByte();
            backgroundColor = reader.ReadInt();
        }
        
    }
    
}