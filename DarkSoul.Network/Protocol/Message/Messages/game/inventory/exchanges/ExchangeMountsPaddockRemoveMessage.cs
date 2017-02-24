

// Generated on 02/23/2017 16:53:53
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ExchangeMountsPaddockRemoveMessage : NetworkMessage
    {
        public override ushort Id => 6559;
        
        
        public IEnumerable<int> mountsId;
        
        public ExchangeMountsPaddockRemoveMessage()
        {
        }
        
        public ExchangeMountsPaddockRemoveMessage(IEnumerable<int> mountsId)
        {
            this.mountsId = mountsId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)mountsId.Count());
            foreach (var entry in mountsId)
            {
                 writer.WriteVarInt((int)entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            mountsId = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 (mountsId as int[])[i] = reader.ReadVarInt();
            }
        }
        
    }
    
}