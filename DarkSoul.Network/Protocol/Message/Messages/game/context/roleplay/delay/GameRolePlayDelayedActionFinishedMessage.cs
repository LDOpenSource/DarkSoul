

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
    public class GameRolePlayDelayedActionFinishedMessage : NetworkMessage
    {
        public override ushort Id => 6150;
        
        
        public double delayedCharacterId;
        public sbyte delayTypeId;
        
        public GameRolePlayDelayedActionFinishedMessage()
        {
        }
        
        public GameRolePlayDelayedActionFinishedMessage(double delayedCharacterId, sbyte delayTypeId)
        {
            this.delayedCharacterId = delayedCharacterId;
            this.delayTypeId = delayTypeId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteDouble(delayedCharacterId);
            writer.WriteSByte(delayTypeId);
        }
        
        public override void Deserialize(IReader reader)
        {
            delayedCharacterId = reader.ReadDouble();
            delayTypeId = reader.ReadSByte();
        }
        
    }
    
}