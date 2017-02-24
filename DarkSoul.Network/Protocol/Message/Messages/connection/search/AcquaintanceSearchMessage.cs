

// Generated on 02/23/2017 16:53:17
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class AcquaintanceSearchMessage : NetworkMessage
    {
        public override ushort Id => 0x1800;
        
        
        public string nickname;
        
        public AcquaintanceSearchMessage()
        {
        }
        
        public AcquaintanceSearchMessage(string nickname)
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