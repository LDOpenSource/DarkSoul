

// Generated on 02/23/2017 16:53:34
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class MapFightCountMessage : NetworkMessage
    {
        public override ushort Id => 210;
        
        
        public ushort fightCount;
        
        public MapFightCountMessage()
        {
        }
        
        public MapFightCountMessage(ushort fightCount)
        {
            this.fightCount = fightCount;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)fightCount);
        }
        
        public override void Deserialize(IReader reader)
        {
            fightCount = reader.ReadVarUhShort();
        }
        
    }
    
}