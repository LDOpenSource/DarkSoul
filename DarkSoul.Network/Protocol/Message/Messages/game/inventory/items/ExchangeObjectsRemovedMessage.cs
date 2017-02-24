

// Generated on 02/23/2017 16:53:57
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ExchangeObjectsRemovedMessage : ExchangeObjectMessage
    {
        public override ushort Id => 6532;
        
        
        public IEnumerable<uint> objectUID;
        
        public ExchangeObjectsRemovedMessage()
        {
        }
        
        public ExchangeObjectsRemovedMessage(bool remote, IEnumerable<uint> objectUID)
         : base(remote)
        {
            this.objectUID = objectUID;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort((short)objectUID.Count());
            foreach (var entry in objectUID)
            {
                 writer.WriteVarInt((int)entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            var limit = reader.ReadUShort();
            objectUID = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 (objectUID as uint[])[i] = reader.ReadVarUhInt();
            }
        }
        
    }
    
}