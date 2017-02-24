

// Generated on 02/23/2017 16:53:52
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ExchangeBidHouseSearchMessage : NetworkMessage
    {
        public override ushort Id => 5806;
        
        
        public uint type;
        public ushort genId;
        
        public ExchangeBidHouseSearchMessage()
        {
        }
        
        public ExchangeBidHouseSearchMessage(uint type, ushort genId)
        {
            this.type = type;
            this.genId = genId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)type);
            writer.WriteVarShort((int)genId);
        }
        
        public override void Deserialize(IReader reader)
        {
            type = reader.ReadVarUhInt();
            genId = reader.ReadVarUhShort();
        }
        
    }
    
}