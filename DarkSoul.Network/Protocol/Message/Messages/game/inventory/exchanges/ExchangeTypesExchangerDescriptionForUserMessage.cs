

// Generated on 02/23/2017 16:53:56
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ExchangeTypesExchangerDescriptionForUserMessage : NetworkMessage
    {
        public override ushort Id => 5765;
        
        
        public IEnumerable<uint> typeDescription;
        
        public ExchangeTypesExchangerDescriptionForUserMessage()
        {
        }
        
        public ExchangeTypesExchangerDescriptionForUserMessage(IEnumerable<uint> typeDescription)
        {
            this.typeDescription = typeDescription;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)typeDescription.Count());
            foreach (var entry in typeDescription)
            {
                 writer.WriteVarInt((int)entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            typeDescription = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 (typeDescription as uint[])[i] = reader.ReadVarUhInt();
            }
        }
        
    }
    
}