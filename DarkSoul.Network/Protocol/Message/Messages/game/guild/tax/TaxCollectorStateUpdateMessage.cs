

// Generated on 02/23/2017 16:53:50
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class TaxCollectorStateUpdateMessage : NetworkMessage
    {
        public override ushort Id => 6455;
        
        
        public int uniqueId;
        public sbyte state;
        
        public TaxCollectorStateUpdateMessage()
        {
        }
        
        public TaxCollectorStateUpdateMessage(int uniqueId, sbyte state)
        {
            this.uniqueId = uniqueId;
            this.state = state;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteInt(uniqueId);
            writer.WriteSByte(state);
        }
        
        public override void Deserialize(IReader reader)
        {
            uniqueId = reader.ReadInt();
            state = reader.ReadSByte();
        }
        
    }
    
}