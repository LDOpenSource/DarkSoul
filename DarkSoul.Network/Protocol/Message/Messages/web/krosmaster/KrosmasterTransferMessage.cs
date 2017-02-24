

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
    public class KrosmasterTransferMessage : NetworkMessage
    {
        public override ushort Id => 6348;
        
        
        public string uid;
        public sbyte failure;
        
        public KrosmasterTransferMessage()
        {
        }
        
        public KrosmasterTransferMessage(string uid, sbyte failure)
        {
            this.uid = uid;
            this.failure = failure;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteUTF(uid);
            writer.WriteSByte(failure);
        }
        
        public override void Deserialize(IReader reader)
        {
            uid = reader.ReadUTF();
            failure = reader.ReadSByte();
        }
        
    }
    
}