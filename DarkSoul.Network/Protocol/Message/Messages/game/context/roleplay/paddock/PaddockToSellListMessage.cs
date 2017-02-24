

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
    public class PaddockToSellListMessage : NetworkMessage
    {
        public override ushort Id => 6138;
        
        
        public ushort pageIndex;
        public ushort totalPage;
        public IEnumerable<Types.PaddockInformationsForSell> paddockList;
        
        public PaddockToSellListMessage()
        {
        }
        
        public PaddockToSellListMessage(ushort pageIndex, ushort totalPage, IEnumerable<Types.PaddockInformationsForSell> paddockList)
        {
            this.pageIndex = pageIndex;
            this.totalPage = totalPage;
            this.paddockList = paddockList;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)pageIndex);
            writer.WriteVarShort((int)totalPage);
            writer.WriteShort((short)paddockList.Count());
            foreach (var entry in paddockList)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            pageIndex = reader.ReadVarUhShort();
            totalPage = reader.ReadVarUhShort();
            var limit = reader.ReadUShort();
            paddockList = new Types.PaddockInformationsForSell[limit];
            for (int i = 0; i < limit; i++)
            {
                 (paddockList as Types.PaddockInformationsForSell[])[i] = new Types.PaddockInformationsForSell();
                 (paddockList as Types.PaddockInformationsForSell[])[i].Deserialize(reader);
            }
        }
        
    }
    
}