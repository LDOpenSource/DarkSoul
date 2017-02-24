

// Generated on 02/23/2017 16:53:39
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class LockableUseCodeMessage : NetworkMessage
    {
        public override ushort Id => 5667;
        
        
        public string code;
        
        public LockableUseCodeMessage()
        {
        }
        
        public LockableUseCodeMessage(string code)
        {
            this.code = code;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteUTF(code);
        }
        
        public override void Deserialize(IReader reader)
        {
            code = reader.ReadUTF();
        }
        
    }
    
}