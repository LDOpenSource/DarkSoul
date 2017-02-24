

// Generated on 02/23/2017 16:53:35
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class DocumentReadingBeginMessage : NetworkMessage
    {
        public override ushort Id => 5675;
        
        
        public ushort documentId;
        
        public DocumentReadingBeginMessage()
        {
        }
        
        public DocumentReadingBeginMessage(ushort documentId)
        {
            this.documentId = documentId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)documentId);
        }
        
        public override void Deserialize(IReader reader)
        {
            documentId = reader.ReadVarUhShort();
        }
        
    }
    
}