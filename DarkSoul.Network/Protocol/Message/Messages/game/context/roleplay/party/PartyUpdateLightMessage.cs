

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
    public class PartyUpdateLightMessage : AbstractPartyEventMessage
    {
        public override ushort Id => 6054;
        
        
        public double id;
        public uint lifePoints;
        public uint maxLifePoints;
        public ushort prospecting;
        public byte regenRate;
        
        public PartyUpdateLightMessage()
        {
        }
        
        public PartyUpdateLightMessage(uint partyId, double id, uint lifePoints, uint maxLifePoints, ushort prospecting, byte regenRate)
         : base(partyId)
        {
            this.id = id;
            this.lifePoints = lifePoints;
            this.maxLifePoints = maxLifePoints;
            this.prospecting = prospecting;
            this.regenRate = regenRate;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(id);
            writer.WriteVarInt((int)lifePoints);
            writer.WriteVarInt((int)maxLifePoints);
            writer.WriteVarShort((int)prospecting);
            writer.WriteByte(regenRate);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            id = reader.ReadVarUhLong();
            lifePoints = reader.ReadVarUhInt();
            maxLifePoints = reader.ReadVarUhInt();
            prospecting = reader.ReadVarUhShort();
            regenRate = reader.ReadByte();
        }
        
    }
    
}