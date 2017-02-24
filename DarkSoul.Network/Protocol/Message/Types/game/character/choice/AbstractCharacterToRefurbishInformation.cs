

// Generated on 02/23/2017 18:06:38
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class AbstractCharacterToRefurbishInformation : AbstractCharacterInformation
    {
        public override short TypeId => 475;
        
        public IEnumerable<int> colors;
        public uint cosmeticId;
        
        public AbstractCharacterToRefurbishInformation()
        {
        }
        
        public AbstractCharacterToRefurbishInformation(double id, IEnumerable<int> colors, uint cosmeticId)
         : base(id)
        {
            this.colors = colors;
            this.cosmeticId = cosmeticId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort((short)colors.Count());
            foreach (var entry in colors)
            {
                 writer.WriteInt(entry);
            }
            writer.WriteVarInt((int)cosmeticId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            var limit = reader.ReadUShort();
            colors = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 (colors as int[])[i] = reader.ReadInt();
            }
            cosmeticId = reader.ReadVarUhInt();
        }
        
    }
    
}