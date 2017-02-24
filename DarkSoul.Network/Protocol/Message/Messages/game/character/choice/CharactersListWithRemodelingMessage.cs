

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
    public class CharactersListWithRemodelingMessage : CharactersListMessage
    {
        public override ushort Id => 6550;
        
        
        public IEnumerable<Types.CharacterToRemodelInformations> charactersToRemodel;
        
        public CharactersListWithRemodelingMessage()
        {
        }
        
        public CharactersListWithRemodelingMessage(IEnumerable<Types.CharacterBaseInformations> characters, bool hasStartupActions, IEnumerable<Types.CharacterToRemodelInformations> charactersToRemodel)
         : base(characters, hasStartupActions)
        {
            this.charactersToRemodel = charactersToRemodel;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort((short)charactersToRemodel.Count());
            foreach (var entry in charactersToRemodel)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            var limit = reader.ReadUShort();
            charactersToRemodel = new Types.CharacterToRemodelInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (charactersToRemodel as Types.CharacterToRemodelInformations[])[i] = new Types.CharacterToRemodelInformations();
                 (charactersToRemodel as Types.CharacterToRemodelInformations[])[i].Deserialize(reader);
            }
        }
        
    }
    
}