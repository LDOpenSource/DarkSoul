

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
    public class HouseToSellListMessage : NetworkMessage
    {
        public override ushort Id => 6140;
        
        
        public ushort pageIndex;
        public ushort totalPage;
        public IEnumerable<Types.HouseInformationsForSell> houseList;
        
        public HouseToSellListMessage()
        {
        }
        
        public HouseToSellListMessage(ushort pageIndex, ushort totalPage, IEnumerable<Types.HouseInformationsForSell> houseList)
        {
            this.pageIndex = pageIndex;
            this.totalPage = totalPage;
            this.houseList = houseList;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)pageIndex);
            writer.WriteVarShort((int)totalPage);
            writer.WriteShort((short)houseList.Count());
            foreach (var entry in houseList)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            pageIndex = reader.ReadVarUhShort();
            totalPage = reader.ReadVarUhShort();
            var limit = reader.ReadUShort();
            houseList = new Types.HouseInformationsForSell[limit];
            for (int i = 0; i < limit; i++)
            {
                 (houseList as Types.HouseInformationsForSell[])[i] = new Types.HouseInformationsForSell();
                 (houseList as Types.HouseInformationsForSell[])[i].Deserialize(reader);
            }
        }
        
    }
    
}