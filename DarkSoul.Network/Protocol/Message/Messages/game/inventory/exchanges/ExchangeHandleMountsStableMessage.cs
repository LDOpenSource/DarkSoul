

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
    public class ExchangeHandleMountsStableMessage : NetworkMessage
    {
        public override ushort Id => 6562;
        
        
        public sbyte actionType;
        public IEnumerable<uint> ridesId;
        
        public ExchangeHandleMountsStableMessage()
        {
        }
        
        public ExchangeHandleMountsStableMessage(sbyte actionType, IEnumerable<uint> ridesId)
        {
            this.actionType = actionType;
            this.ridesId = ridesId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(actionType);
            writer.WriteShort((short)ridesId.Count());
            foreach (var entry in ridesId)
            {
                 writer.WriteVarInt((int)entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            actionType = reader.ReadSByte();
            var limit = reader.ReadUShort();
            ridesId = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 (ridesId as uint[])[i] = reader.ReadVarUhInt();
            }
        }
        
    }
    
}