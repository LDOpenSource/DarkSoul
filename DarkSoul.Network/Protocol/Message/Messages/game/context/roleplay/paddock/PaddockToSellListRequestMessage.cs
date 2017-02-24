

// Generated on 02/23/2017 16:53:40
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class PaddockToSellListRequestMessage : NetworkMessage
    {
        public override ushort Id => 6141;
        
        
        public ushort pageIndex;
        
        public PaddockToSellListRequestMessage()
        {
        }
        
        public PaddockToSellListRequestMessage(ushort pageIndex)
        {
            this.pageIndex = pageIndex;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)pageIndex);
        }
        
        public override void Deserialize(IReader reader)
        {
            pageIndex = reader.ReadVarUhShort();
        }
        
    }
    
}