

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
    public class CharacterDeletionRequestMessage : NetworkMessage
    {
        public override ushort Id => 165;
        
        
        public double characterId;
        public string secretAnswerHash;
        
        public CharacterDeletionRequestMessage()
        {
        }
        
        public CharacterDeletionRequestMessage(double characterId, string secretAnswerHash)
        {
            this.characterId = characterId;
            this.secretAnswerHash = secretAnswerHash;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarLong(characterId);
            writer.WriteUTF(secretAnswerHash);
        }
        
        public override void Deserialize(IReader reader)
        {
            characterId = reader.ReadVarUhLong();
            secretAnswerHash = reader.ReadUTF();
        }
        
    }
    
}