

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
    public class ComicReadingBeginMessage : NetworkMessage
    {
        public override ushort Id => 6536;
        
        
        public ushort comicId;
        
        public ComicReadingBeginMessage()
        {
        }
        
        public ComicReadingBeginMessage(ushort comicId)
        {
            this.comicId = comicId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)comicId);
        }
        
        public override void Deserialize(IReader reader)
        {
            comicId = reader.ReadVarUhShort();
        }
        
    }
    
}