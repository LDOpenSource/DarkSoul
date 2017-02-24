

// Generated on 02/23/2017 16:53:32
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameDataPaddockObjectListAddMessage : NetworkMessage
    {
        public override ushort Id => 5992;
        
        
        public IEnumerable<Types.PaddockItem> paddockItemDescription;
        
        public GameDataPaddockObjectListAddMessage()
        {
        }
        
        public GameDataPaddockObjectListAddMessage(IEnumerable<Types.PaddockItem> paddockItemDescription)
        {
            this.paddockItemDescription = paddockItemDescription;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)paddockItemDescription.Count());
            foreach (var entry in paddockItemDescription)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            paddockItemDescription = new Types.PaddockItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 (paddockItemDescription as Types.PaddockItem[])[i] = new Types.PaddockItem();
                 (paddockItemDescription as Types.PaddockItem[])[i].Deserialize(reader);
            }
        }
        
    }
    
}