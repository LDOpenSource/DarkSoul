

// Generated on 02/23/2017 16:53:16
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class NicknameChoiceRequestMessage : NetworkMessage
    {
        public override ushort Id => 5639;
        
        
        public string nickname;
        
        public NicknameChoiceRequestMessage()
        {
        }
        
        public NicknameChoiceRequestMessage(string nickname)
        {
            this.nickname = nickname;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteUTF(nickname);
        }
        
        public override void Deserialize(IReader reader)
        {
            nickname = reader.ReadUTF();
        }
        
    }
    
}