

// Generated on 02/23/2017 18:06:38
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class RemodelingInformation
    {
        public virtual short TypeId => 480;
        
        public string name;
        public sbyte breed;
        public bool sex;
        public ushort cosmeticId;
        public IEnumerable<int> colors;
        
        public RemodelingInformation()
        {
        }
        
        public RemodelingInformation(string name, sbyte breed, bool sex, ushort cosmeticId, IEnumerable<int> colors)
        {
            this.name = name;
            this.breed = breed;
            this.sex = sex;
            this.cosmeticId = cosmeticId;
            this.colors = colors;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteUTF(name);
            writer.WriteSByte(breed);
            writer.WriteBoolean(sex);
            writer.WriteVarShort((int)cosmeticId);
            writer.WriteShort((short)colors.Count());
            foreach (var entry in colors)
            {
                 writer.WriteInt(entry);
            }
        }
        
        public virtual void Deserialize(IReader reader)
        {
            name = reader.ReadUTF();
            breed = reader.ReadSByte();
            sex = reader.ReadBoolean();
            cosmeticId = reader.ReadVarUhShort();
            var limit = reader.ReadUShort();
            colors = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 (colors as int[])[i] = reader.ReadInt();
            }
        }
        
    }
    
}