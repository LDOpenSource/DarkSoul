

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
    public class ExchangeCraftInformationObjectMessage : ExchangeCraftResultWithObjectIdMessage
    {
        public override ushort Id => 5794;
        
        
        public double playerId;
        
        public ExchangeCraftInformationObjectMessage()
        {
        }
        
        public ExchangeCraftInformationObjectMessage(sbyte craftResult, ushort objectGenericId, double playerId)
         : base(craftResult, objectGenericId)
        {
            this.playerId = playerId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(playerId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            playerId = reader.ReadVarUhLong();
        }
        
    }
    
}