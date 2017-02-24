

// Generated on 02/23/2017 16:53:59
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ObjectUseMultipleMessage : ObjectUseMessage
    {
        public override ushort Id => 6234;
        
        
        public uint quantity;
        
        public ObjectUseMultipleMessage()
        {
        }
        
        public ObjectUseMultipleMessage(uint objectUID, uint quantity)
         : base(objectUID)
        {
            this.quantity = quantity;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt((int)quantity);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            quantity = reader.ReadVarUhInt();
        }
        
    }
    
}