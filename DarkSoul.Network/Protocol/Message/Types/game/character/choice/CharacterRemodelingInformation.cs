

// Generated on 02/23/2017 18:06:38
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class CharacterRemodelingInformation : AbstractCharacterInformation
    {
        public override short TypeId => 479;
        
        public string name;
        public sbyte breed;
        public bool sex;
        public ushort cosmeticId;
        public IEnumerable<int> colors;
        
        public CharacterRemodelingInformation()
        {
        }
        
        public CharacterRemodelingInformation(double id, string name, sbyte breed, bool sex, ushort cosmeticId, IEnumerable<int> colors)
         : base(id)
        {
            this.name = name;
            this.breed = breed;
            this.sex = sex;
            this.cosmeticId = cosmeticId;
            this.colors = colors;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
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
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
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