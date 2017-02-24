

// Generated on 02/23/2017 16:54:04
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class DownloadErrorMessage : NetworkMessage
    {
        public override ushort Id => 1513;
        
        
        public sbyte errorId;
        public string message;
        public string helpUrl;
        
        public DownloadErrorMessage()
        {
        }
        
        public DownloadErrorMessage(sbyte errorId, string message, string helpUrl)
        {
            this.errorId = errorId;
            this.message = message;
            this.helpUrl = helpUrl;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(errorId);
            writer.WriteUTF(message);
            writer.WriteUTF(helpUrl);
        }
        
        public override void Deserialize(IReader reader)
        {
            errorId = reader.ReadSByte();
            message = reader.ReadUTF();
            helpUrl = reader.ReadUTF();
        }
        
    }
    
}