

// Generated on 02/23/2017 16:53:43
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class PartyCompanionUpdateLightMessage : PartyUpdateLightMessage
    {
        public override ushort Id => 6472;
        
        
        public sbyte indexId;
        
        public PartyCompanionUpdateLightMessage()
        {
        }
        
        public PartyCompanionUpdateLightMessage(uint partyId, double id, uint lifePoints, uint maxLifePoints, ushort prospecting, byte regenRate, sbyte indexId)
         : base(partyId, id, lifePoints, maxLifePoints, prospecting, regenRate)
        {
            this.indexId = indexId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSByte(indexId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            indexId = reader.ReadSByte();
        }
        
    }
    
}