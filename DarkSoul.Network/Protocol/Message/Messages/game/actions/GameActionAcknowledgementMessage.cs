

// Generated on 02/23/2017 16:53:18
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameActionAcknowledgementMessage : NetworkMessage
    {
        public override ushort Id => 957;
        
        
        public bool valid;
        public sbyte actionId;
        
        public GameActionAcknowledgementMessage()
        {
        }
        
        public GameActionAcknowledgementMessage(bool valid, sbyte actionId)
        {
            this.valid = valid;
            this.actionId = actionId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteBoolean(valid);
            writer.WriteSByte(actionId);
        }
        
        public override void Deserialize(IReader reader)
        {
            valid = reader.ReadBoolean();
            actionId = reader.ReadSByte();
        }
        
    }
    
}