

// Generated on 02/23/2017 16:53:37
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class HouseToSellListRequestMessage : NetworkMessage
    {
        public override ushort Id => 6139;
        
        
        public ushort pageIndex;
        
        public HouseToSellListRequestMessage()
        {
        }
        
        public HouseToSellListRequestMessage(ushort pageIndex)
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