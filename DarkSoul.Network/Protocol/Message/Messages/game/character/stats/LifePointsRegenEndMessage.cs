

// Generated on 02/23/2017 16:53:26
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class LifePointsRegenEndMessage : UpdateLifePointsMessage
    {
        public override ushort Id => 5686;
        
        
        public uint lifePointsGained;
        
        public LifePointsRegenEndMessage()
        {
        }
        
        public LifePointsRegenEndMessage(uint lifePoints, uint maxLifePoints, uint lifePointsGained)
         : base(lifePoints, maxLifePoints)
        {
            this.lifePointsGained = lifePointsGained;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt((int)lifePointsGained);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            lifePointsGained = reader.ReadVarUhInt();
        }
        
    }
    
}