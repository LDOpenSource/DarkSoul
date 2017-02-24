

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
    public class FocusedExchangeReadyMessage : ExchangeReadyMessage
    {
        public override ushort Id => 6701;
        
        
        public uint focusActionId;
        
        public FocusedExchangeReadyMessage()
        {
        }
        
        public FocusedExchangeReadyMessage(bool ready, ushort step, uint focusActionId)
         : base(ready, step)
        {
            this.focusActionId = focusActionId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt((int)focusActionId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            focusActionId = reader.ReadVarUhInt();
        }
        
    }
    
}