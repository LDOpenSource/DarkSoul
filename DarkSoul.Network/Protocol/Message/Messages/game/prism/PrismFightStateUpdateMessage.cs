

// Generated on 02/23/2017 16:54:01
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class PrismFightStateUpdateMessage : NetworkMessage
    {
        public override ushort Id => 6040;
        
        
        public sbyte state;
        
        public PrismFightStateUpdateMessage()
        {
        }
        
        public PrismFightStateUpdateMessage(sbyte state)
        {
            this.state = state;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(state);
        }
        
        public override void Deserialize(IReader reader)
        {
            state = reader.ReadSByte();
        }
        
    }
    
}