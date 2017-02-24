

// Generated on 02/23/2017 16:53:24
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class BasicCharactersListMessage : NetworkMessage
    {
        public override ushort Id => 6475;
        
        
        public IEnumerable<Types.CharacterBaseInformations> characters;
        
        public BasicCharactersListMessage()
        {
        }
        
        public BasicCharactersListMessage(IEnumerable<Types.CharacterBaseInformations> characters)
        {
            this.characters = characters;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)characters.Count());
            foreach (var entry in characters)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            characters = new Types.CharacterBaseInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (characters as Types.CharacterBaseInformations[])[i] = ProtocolTypeManager.GetInstance<Types.CharacterBaseInformations>(reader.ReadUShort());
                 (characters as Types.CharacterBaseInformations[])[i].Deserialize(reader);
            }
        }
        
    }
    
}