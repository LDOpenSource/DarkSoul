

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
    public class CharactersListWithModificationsMessage : CharactersListMessage
    {
        public override ushort Id => 6120;
        
        
        public IEnumerable<Types.CharacterToRecolorInformation> charactersToRecolor;
        public IEnumerable<int> charactersToRename;
        public IEnumerable<int> unusableCharacters;
        public IEnumerable<Types.CharacterToRelookInformation> charactersToRelook;
        
        public CharactersListWithModificationsMessage()
        {
        }
        
        public CharactersListWithModificationsMessage(IEnumerable<Types.CharacterBaseInformations> characters, bool hasStartupActions, IEnumerable<Types.CharacterToRecolorInformation> charactersToRecolor, IEnumerable<int> charactersToRename, IEnumerable<int> unusableCharacters, IEnumerable<Types.CharacterToRelookInformation> charactersToRelook)
         : base(characters, hasStartupActions)
        {
            this.charactersToRecolor = charactersToRecolor;
            this.charactersToRename = charactersToRename;
            this.unusableCharacters = unusableCharacters;
            this.charactersToRelook = charactersToRelook;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort((short)charactersToRecolor.Count());
            foreach (var entry in charactersToRecolor)
            {
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)charactersToRename.Count());
            foreach (var entry in charactersToRename)
            {
                 writer.WriteInt(entry);
            }
            writer.WriteShort((short)unusableCharacters.Count());
            foreach (var entry in unusableCharacters)
            {
                 writer.WriteInt(entry);
            }
            writer.WriteShort((short)charactersToRelook.Count());
            foreach (var entry in charactersToRelook)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            var limit = reader.ReadUShort();
            charactersToRecolor = new Types.CharacterToRecolorInformation[limit];
            for (int i = 0; i < limit; i++)
            {
                 (charactersToRecolor as Types.CharacterToRecolorInformation[])[i] = new Types.CharacterToRecolorInformation();
                 (charactersToRecolor as Types.CharacterToRecolorInformation[])[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            charactersToRename = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 (charactersToRename as int[])[i] = reader.ReadInt();
            }
            limit = reader.ReadUShort();
            unusableCharacters = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 (unusableCharacters as int[])[i] = reader.ReadInt();
            }
            limit = reader.ReadUShort();
            charactersToRelook = new Types.CharacterToRelookInformation[limit];
            for (int i = 0; i < limit; i++)
            {
                 (charactersToRelook as Types.CharacterToRelookInformation[])[i] = new Types.CharacterToRelookInformation();
                 (charactersToRelook as Types.CharacterToRelookInformation[])[i].Deserialize(reader);
            }
        }
        
    }
    
}