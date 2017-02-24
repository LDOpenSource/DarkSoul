

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
    public class ExchangeObjectRemovedMessage : ExchangeObjectMessage
    {
        public override ushort Id => 5517;
        
        
        public uint objectUID;
        
        public ExchangeObjectRemovedMessage()
        {
        }
        
        public ExchangeObjectRemovedMessage(bool remote, uint objectUID)
         : base(remote)
        {
            this.objectUID = objectUID;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt((int)objectUID);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            objectUID = reader.ReadVarUhInt();
        }
        
    }
    
}