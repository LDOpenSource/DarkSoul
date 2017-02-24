

// Generated on 02/23/2017 16:53:25
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class CharacterCreationRequestMessage : NetworkMessage
    {
        public override ushort Id => 160;
        
        
        public string name;
        public sbyte breed;
        public bool sex;
        public IEnumerable<int> colors;
        public ushort cosmeticId;
        
        public CharacterCreationRequestMessage()
        {
        }
        
        public CharacterCreationRequestMessage(string name, sbyte breed, bool sex, IEnumerable<int> colors, ushort cosmeticId)
        {
            this.name = name;
            this.breed = breed;
            this.sex = sex;
            this.colors = colors;
            this.cosmeticId = cosmeticId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteUTF(name);
            writer.WriteSByte(breed);
            writer.WriteBoolean(sex);
            foreach (var entry in colors)
            {
                 writer.WriteInt(entry);
            }
            writer.WriteVarShort((int)cosmeticId);
        }
        
        public override void Deserialize(IReader reader)
        {
            name = reader.ReadUTF();
            breed = reader.ReadSByte();
            sex = reader.ReadBoolean();
            colors = new int[5];
            for (int i = 0; i < 5; i++)
            {
                 (colors as int[])[i] = reader.ReadInt();
            }
            cosmeticId = reader.ReadVarUhShort();
        }
        
    }
    
}