

// Generated on 02/23/2017 16:53:34
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameRolePlayDelayedActionMessage : NetworkMessage
    {
        public override ushort Id => 6153;
        
        
        public double delayedCharacterId;
        public sbyte delayTypeId;
        public double delayEndTime;
        
        public GameRolePlayDelayedActionMessage()
        {
        }
        
        public GameRolePlayDelayedActionMessage(double delayedCharacterId, sbyte delayTypeId, double delayEndTime)
        {
            this.delayedCharacterId = delayedCharacterId;
            this.delayTypeId = delayTypeId;
            this.delayEndTime = delayEndTime;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteDouble(delayedCharacterId);
            writer.WriteSByte(delayTypeId);
            writer.WriteDouble(delayEndTime);
        }
        
        public override void Deserialize(IReader reader)
        {
            delayedCharacterId = reader.ReadDouble();
            delayTypeId = reader.ReadSByte();
            delayEndTime = reader.ReadDouble();
        }
        
    }
    
}