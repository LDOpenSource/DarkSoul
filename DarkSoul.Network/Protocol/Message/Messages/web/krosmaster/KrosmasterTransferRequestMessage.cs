

// Generated on 02/23/2017 16:54:05
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class KrosmasterTransferRequestMessage : NetworkMessage
    {
        public override ushort Id => 6349;
        
        
        public string uid;
        
        public KrosmasterTransferRequestMessage()
        {
        }
        
        public KrosmasterTransferRequestMessage(string uid)
        {
            this.uid = uid;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteUTF(uid);
        }
        
        public override void Deserialize(IReader reader)
        {
            uid = reader.ReadUTF();
        }
        
    }
    
}