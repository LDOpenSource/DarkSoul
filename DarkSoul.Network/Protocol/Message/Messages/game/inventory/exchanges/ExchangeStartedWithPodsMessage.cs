

// Generated on 02/23/2017 16:53:56
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ExchangeStartedWithPodsMessage : ExchangeStartedMessage
    {
        public override ushort Id => 6129;
        
        
        public double firstCharacterId;
        public uint firstCharacterCurrentWeight;
        public uint firstCharacterMaxWeight;
        public double secondCharacterId;
        public uint secondCharacterCurrentWeight;
        public uint secondCharacterMaxWeight;
        
        public ExchangeStartedWithPodsMessage()
        {
        }
        
        public ExchangeStartedWithPodsMessage(sbyte exchangeType, double firstCharacterId, uint firstCharacterCurrentWeight, uint firstCharacterMaxWeight, double secondCharacterId, uint secondCharacterCurrentWeight, uint secondCharacterMaxWeight)
         : base(exchangeType)
        {
            this.firstCharacterId = firstCharacterId;
            this.firstCharacterCurrentWeight = firstCharacterCurrentWeight;
            this.firstCharacterMaxWeight = firstCharacterMaxWeight;
            this.secondCharacterId = secondCharacterId;
            this.secondCharacterCurrentWeight = secondCharacterCurrentWeight;
            this.secondCharacterMaxWeight = secondCharacterMaxWeight;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(firstCharacterId);
            writer.WriteVarInt((int)firstCharacterCurrentWeight);
            writer.WriteVarInt((int)firstCharacterMaxWeight);
            writer.WriteDouble(secondCharacterId);
            writer.WriteVarInt((int)secondCharacterCurrentWeight);
            writer.WriteVarInt((int)secondCharacterMaxWeight);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            firstCharacterId = reader.ReadDouble();
            firstCharacterCurrentWeight = reader.ReadVarUhInt();
            firstCharacterMaxWeight = reader.ReadVarUhInt();
            secondCharacterId = reader.ReadDouble();
            secondCharacterCurrentWeight = reader.ReadVarUhInt();
            secondCharacterMaxWeight = reader.ReadVarUhInt();
        }
        
    }
    
}