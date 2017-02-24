

// Generated on 02/23/2017 16:53:54
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ExchangeObjectTransfertListWithQuantityToInvMessage : NetworkMessage
    {
        public override ushort Id => 6470;
        
        
        public IEnumerable<uint> ids;
        public IEnumerable<uint> qtys;
        
        public ExchangeObjectTransfertListWithQuantityToInvMessage()
        {
        }
        
        public ExchangeObjectTransfertListWithQuantityToInvMessage(IEnumerable<uint> ids, IEnumerable<uint> qtys)
        {
            this.ids = ids;
            this.qtys = qtys;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)ids.Count());
            foreach (var entry in ids)
            {
                 writer.WriteVarInt((int)entry);
            }
            writer.WriteShort((short)qtys.Count());
            foreach (var entry in qtys)
            {
                 writer.WriteVarInt((int)entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            ids = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 (ids as uint[])[i] = reader.ReadVarUhInt();
            }
            limit = reader.ReadUShort();
            qtys = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 (qtys as uint[])[i] = reader.ReadVarUhInt();
            }
        }
        
    }
    
}